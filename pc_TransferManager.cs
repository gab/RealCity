﻿using System;
using ColossalFramework;
using System.Reflection;

namespace RealCity
{
    public class pc_TransferManager
    {
        /// <summary>
        /// Point of note: This is a static function whereas the original function uses __thiscall.
        /// On x64 machines only __fastcall is left, which means that the first parameter lives in
        /// RCX - which conveniently conincides with the register usually used for the this-ptr 
        /// (at least on Windows).
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="material"></param>
        /// <param name="offer"></param>
        /// 
        // TransferManager

        public void Init()
        {
            DebugLog.LogToFileOnly("Init fake transfer manager");
            try
            {
                var inst = Singleton<TransferManager>.instance;
                //var incomingCount = typeof(TransferManager).GetField("m_incomingCount", BindingFlags.NonPublic | BindingFlags.Instance);
                //var incomingOffers = typeof(TransferManager).GetField("m_incomingOffers", BindingFlags.NonPublic | BindingFlags.Instance);
                //var incomingAmount = typeof(TransferManager).GetField("m_incomingAmount", BindingFlags.NonPublic | BindingFlags.Instance);
                var outgoingCount = typeof(TransferManager).GetField("m_outgoingCount", BindingFlags.NonPublic | BindingFlags.Instance);
                var outgoingOffers = typeof(TransferManager).GetField("m_outgoingOffers", BindingFlags.NonPublic | BindingFlags.Instance);
                var outgoingAmount = typeof(TransferManager).GetField("m_outgoingAmount", BindingFlags.NonPublic | BindingFlags.Instance);
                if (inst == null)
                {
                    DebugLog.LogToFileOnly("No instance of TransferManager found!");
                    return;
                }
                //_incomingCount = incomingCount.GetValue(inst) as ushort[];
                //_incomingOffers = incomingOffers.GetValue(inst) as TransferManager.TransferOffer[];
                //_incomingAmount = incomingAmount.GetValue(inst) as int[];
                _outgoingCount = outgoingCount.GetValue(inst) as ushort[];
                _outgoingOffers = outgoingOffers.GetValue(inst) as TransferManager.TransferOffer[];
                _outgoingAmount = outgoingAmount.GetValue(inst) as int[];
                if (_outgoingCount == null || _outgoingOffers == null || _outgoingAmount == null)
                {
                    DebugLog.LogToFileOnly("TransferManager Arrays are null");
                }
            }
            catch (Exception ex)
            {
                DebugLog.LogToFileOnly("TransferManager Exception: " + ex.Message);
            }
        }
        private static TransferManager.TransferOffer[] _outgoingOffers;
        private static ushort[] _outgoingCount;
        private static int[] _outgoingAmount;
        //private static TransferManager.TransferOffer[] _incomingOffers;
        //private static ushort[] _incomingCount;
        //private static int[] _incomingAmount;
        private static bool _init = false;


        public static bool IsBuildingOutside(UnityEngine.Vector3 position)
        {
            if ((position.x < 8600) && (position.x > -8600) && (position.z < 8600) && (position.z > -8600))
            {
                return false;

            }
            return true;
        }

        public void ProcessShoppingAndEntertainment(TransferManager.TransferReason material, TransferManager.TransferOffer offerOut, TransferManager.TransferOffer offerIn, int delta)
        {
            Array32<Citizen> citizens = Singleton<CitizenManager>.instance.m_citizens;
            uint citizen = offerIn.Citizen;
            CitizenInfo citizenInfo = citizens.m_buffer[(int)((UIntPtr)citizen)].GetCitizenInfo(citizen);
            ushort homeBuilding = citizens.m_buffer[(int)((UIntPtr)citizen)].m_homeBuilding;
            BuildingManager instance2 = Singleton<BuildingManager>.instance;
            uint homeId = citizens.m_buffer[citizen].GetContainingUnit(citizen, instance2.m_buildings.m_buffer[(int)homeBuilding].m_citizenUnits, CitizenUnit.Flags.Home);
            switch (material)
            {
                case TransferManager.TransferReason.Shopping:
                case TransferManager.TransferReason.ShoppingB:
                case TransferManager.TransferReason.ShoppingC:
                case TransferManager.TransferReason.ShoppingD:
                case TransferManager.TransferReason.ShoppingE:
                case TransferManager.TransferReason.ShoppingF:
                case TransferManager.TransferReason.ShoppingG:
                case TransferManager.TransferReason.ShoppingH:
                case TransferManager.TransferReason.Entertainment:
                case TransferManager.TransferReason.EntertainmentB:
                case TransferManager.TransferReason.EntertainmentC:
                case TransferManager.TransferReason.EntertainmentD:
                    if (((citizens.m_buffer[citizen].m_flags & Citizen.Flags.Tourist) == Citizen.Flags.None) && comm_data.family_money[homeId] >= 2000f)
                    {
                        if (citizenInfo != null)
                        {
                            offerOut.Amount = delta;
                            citizenInfo.m_citizenAI.StartTransfer(citizen, ref citizens.m_buffer[(int)((UIntPtr)citizen)], material, offerOut);
                        }
                    }
                    else if ((citizens.m_buffer[citizen].m_flags & Citizen.Flags.Tourist) != Citizen.Flags.None)
                    {
                        if (citizenInfo != null)
                        {
                            offerOut.Amount = delta;
                            citizenInfo.m_citizenAI.StartTransfer(citizen, ref citizens.m_buffer[(int)((UIntPtr)citizen)], material, offerOut);
                        }
                    }
                    else
                    {
                        //DebugLog.LogToFileOnly("citizen is too poor and wont go to shopping and entertainment");
                    }
                    break;
                default:
                    if (citizenInfo != null)
                    {
                        offerOut.Amount = delta;
                        citizenInfo.m_citizenAI.StartTransfer(citizen, ref citizens.m_buffer[(int)((UIntPtr)citizen)], material, offerOut);
                    }
                    break;
            }
        }

        private void StartTransfer(TransferManager.TransferReason material, TransferManager.TransferOffer offerOut, TransferManager.TransferOffer offerIn, int delta)
        {
            bool active = offerIn.Active;
            bool active2 = offerOut.Active;
            if (active && offerIn.Vehicle != 0)
            {
                Array16<Vehicle> vehicles = Singleton<VehicleManager>.instance.m_vehicles;
                ushort vehicle = offerIn.Vehicle;
                VehicleInfo info = vehicles.m_buffer[(int)vehicle].Info;
                offerOut.Amount = delta;
                info.m_vehicleAI.StartTransfer(vehicle, ref vehicles.m_buffer[(int)vehicle], material, offerOut);
            }
            else if (active2 && offerOut.Vehicle != 0)
            {
                Array16<Vehicle> vehicles2 = Singleton<VehicleManager>.instance.m_vehicles;
                ushort vehicle2 = offerOut.Vehicle;
                VehicleInfo info2 = vehicles2.m_buffer[(int)vehicle2].Info;
                offerIn.Amount = delta;
                info2.m_vehicleAI.StartTransfer(vehicle2, ref vehicles2.m_buffer[(int)vehicle2], material, offerIn);
            }
            else if (active && offerIn.Citizen != 0u)
            {
                ProcessShoppingAndEntertainment(material, offerOut, offerIn, delta);
            }
            else if (active2 && offerOut.Citizen != 0u)
            {
                if (material == TransferManager.TransferReason.Shopping || material == TransferManager.TransferReason.ShoppingB || material == TransferManager.TransferReason.Entertainment || material == TransferManager.TransferReason.EntertainmentB)
                {
                    DebugLog.LogToFileOnly("citizen offout shopping??");
                }
                Array32<Citizen> citizens2 = Singleton<CitizenManager>.instance.m_citizens;
                uint citizen2 = offerOut.Citizen;
                CitizenInfo citizenInfo2 = citizens2.m_buffer[(int)((UIntPtr)citizen2)].GetCitizenInfo(citizen2);
                if (citizenInfo2 != null)
                {
                    offerIn.Amount = delta;
                    citizenInfo2.m_citizenAI.StartTransfer(citizen2, ref citizens2.m_buffer[(int)((UIntPtr)citizen2)], material, offerIn);
                }
            }
            else if (active2 && offerOut.Building != 0)
            {
                Array16<Building> buildings = Singleton<BuildingManager>.instance.m_buildings;
                ushort building = offerOut.Building;
                ushort building1 = offerIn.Building;
                BuildingInfo info3 = buildings.m_buffer[(int)building].Info;
                offerIn.Amount = delta;
                info3.m_buildingAI.StartTransfer(building, ref buildings.m_buffer[(int)building], material, offerIn);
            }
            else if (active && offerIn.Building != 0)
            {
                Array16<Building> buildings2 = Singleton<BuildingManager>.instance.m_buildings;
                ushort building2 = offerIn.Building;
                BuildingInfo info4 = buildings2.m_buffer[(int)building2].Info;
                offerOut.Amount = delta;
                info4.m_buildingAI.StartTransfer(building2, ref buildings2.m_buffer[(int)building2], material, offerOut);
            }
        }

        public void AddOutgoingOffer(TransferManager.TransferReason material, TransferManager.TransferOffer offer)
        {
            if (!_init)
            {
                _init = true;
                Init();
            }


            if (Singleton<BuildingManager>.instance.m_buildings.m_buffer[offer.Building].m_flags.IsFlagSet(Building.Flags.IncomingOutgoing))
            {
                //Hell mode no import
                if(comm_data.isHellMode)
                {
                    if(Singleton<UnlockManager>.instance.Unlocked(ItemClass.SubService.IndustrialFarming))
                    {
                        if (material == TransferManager.TransferReason.Food || material == TransferManager.TransferReason.Grain)
                        {
                            return;
                        }
                    }

                    if (Singleton<UnlockManager>.instance.Unlocked(ItemClass.SubService.IndustrialForestry))
                    {
                        if (material == TransferManager.TransferReason.Lumber || material == TransferManager.TransferReason.Logs)
                        {
                            return;
                        }
                    }

                    if (Singleton<UnlockManager>.instance.Unlocked(ItemClass.SubService.IndustrialOil))
                    {
                        if (material == TransferManager.TransferReason.Oil || material == TransferManager.TransferReason.Petrol)
                        {
                            return;
                        }
                    }

                    if (Singleton<UnlockManager>.instance.Unlocked(ItemClass.SubService.IndustrialOre))
                    {
                        if (material == TransferManager.TransferReason.Coal || material == TransferManager.TransferReason.Ore)
                        {
                            return;
                        }
                    }
                }
            }

            if (!comm_data.isPetrolsGettedFinal)
            {
                if(material == TransferManager.TransferReason.Garbage || material == TransferManager.TransferReason.GarbageMove)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.Fire || material == TransferManager.TransferReason.Fire2)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.SickMove || material == TransferManager.TransferReason.Sick2 || material == TransferManager.TransferReason.Sick)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.Dead || material == TransferManager.TransferReason.DeadMove)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.RoadMaintenance || material == TransferManager.TransferReason.Taxi)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.Snow || material == TransferManager.TransferReason.SnowMove)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.Crime || material == TransferManager.TransferReason.CriminalMove)
                {
                    return;
                }

                if (material == TransferManager.TransferReason.Bus || material == TransferManager.TransferReason.TouristBus)
                {
                    return;
                }
            }


            for (int priority = offer.Priority; priority >= 0; --priority)
            {
                int index = (int)material * 8 + priority;
                int count = _outgoingCount[index];
                if (count < 256)
                {
                    //here we caculate needs
                    _outgoingOffers[index * 256 + count] = offer;
                    _outgoingCount[index] = (ushort)(count + 1);
                    _outgoingAmount[(int)material] += offer.Amount;
                    return;
                }
            }
        }



    }//end publi
}//end naming space 