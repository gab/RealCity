﻿using ColossalFramework;
using ColossalFramework.Math;
using RealCity.Util;
using RealCity.UI;
using System;

namespace RealCity.CustomAI
{

    public class RealCityPrivateBuildingAI
    {
        public static ushort allBuildings = 0;
        public static uint preBuidlingId = 0;

        public static ushort allOfficeLevel1BuildingCount = 0;
        public static ushort allOfficeLevel2BuildingCount = 0;
        public static ushort allOfficeLevel3BuildingCount = 0;
        public static ushort allOfficeHighTechBuildingCount = 0;

        public static ushort allOfficeLevel1BuildingCountFinal = 0;
        public static ushort allOfficeLevel2BuildingCountFinal = 0;
        public static ushort allOfficeLevel3BuildingCountFinal = 0;
        public static ushort allOfficeHighTechBuildingCountFinal = 0;
        public static long profitBuildingMoney = 0;
        public static long profitBuildingMoneyFinal = 0;
        public static ushort profitBuildingCount = 0;
        public static ushort profitBuildingCountFinal = 0;
        public static ushort allBuildingsFinal = 0;

        public static byte[] saveData = new byte[44];

        public static void Load()
        {
            int i = 0;
            preBuidlingId = SaveAndRestore.load_uint(ref i, saveData);
            allBuildings = SaveAndRestore.load_ushort(ref i, saveData);
            allBuildingsFinal = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel1BuildingCount = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel2BuildingCount = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel3BuildingCount = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeHighTechBuildingCount = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel1BuildingCountFinal = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel2BuildingCountFinal = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeLevel3BuildingCountFinal = SaveAndRestore.load_ushort(ref i, saveData);
            allOfficeHighTechBuildingCountFinal = SaveAndRestore.load_ushort(ref i, saveData);
            profitBuildingMoney = SaveAndRestore.load_long(ref i, saveData);
            profitBuildingMoneyFinal = SaveAndRestore.load_long(ref i, saveData);
            profitBuildingCount = SaveAndRestore.load_ushort(ref i, saveData);
            profitBuildingCountFinal = SaveAndRestore.load_ushort(ref i, saveData);
            DebugLog.LogToFileOnly("saveData in private building is " + i.ToString());
        }


        public static void save()
        {
            int i = 0;

            //12*2 + 7*4 = 52
            SaveAndRestore.save_uint(ref i, preBuidlingId, ref saveData);

            //20 + 20
            SaveAndRestore.save_ushort(ref i, allBuildings, ref saveData);
            SaveAndRestore.save_ushort(ref i, allBuildingsFinal, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel1BuildingCount, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel2BuildingCount, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel3BuildingCount, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeHighTechBuildingCount, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel1BuildingCountFinal, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel2BuildingCountFinal, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeLevel3BuildingCountFinal, ref saveData);
            SaveAndRestore.save_ushort(ref i, allOfficeHighTechBuildingCountFinal, ref saveData);

            SaveAndRestore.save_long(ref i, profitBuildingMoney, ref saveData);
            SaveAndRestore.save_long(ref i, profitBuildingMoneyFinal, ref saveData);
            SaveAndRestore.save_ushort(ref i, profitBuildingCount, ref saveData);
            SaveAndRestore.save_ushort(ref i, profitBuildingCountFinal, ref saveData);
        }
        //TODO: move to harmony
        public static void PrivateBuildingAISimulationStepActivePostFix(ushort buildingID, ref Building buildingData, ref Building.Frame frameData)
        {
            //TODO, use harmony to detour this.
            ProcessLandFee(buildingData, buildingID);
            LimitAndCheckBuildingMoney(buildingData, buildingID);
            ProcessBuildingDataFinal(buildingID, ref buildingData);
            ProcessAdditionProduct(buildingID, ref buildingData);
        }

        public static long GetResidentialBuildingAverageMoney(ushort buildingID, ref Building buildingData)
        {
            CitizenManager instance = Singleton<CitizenManager>.instance;
            uint num = buildingData.m_citizenUnits;
            int num2 = 0;
            long totalMoney = 0;
            long averageMoney = 0;
            while (num != 0u)
            {
                if ((ushort)(instance.m_units.m_buffer[(int)((UIntPtr)num)].m_flags & CitizenUnit.Flags.Home) != 0)
                {
                    if((instance.m_units.m_buffer[(int)((UIntPtr)num)].m_citizen0 != 0) || (instance.m_units.m_buffer[(int)((UIntPtr)num)].m_citizen1 != 0) || (instance.m_units.m_buffer[(int)((UIntPtr)num)].m_citizen2 != 0) || (instance.m_units.m_buffer[(int)((UIntPtr)num)].m_citizen3 != 0) || (instance.m_units.m_buffer[(int)((UIntPtr)num)].m_citizen4 != 0))
                    {
                        num2++;
                        totalMoney += (long)MainDataStore.family_money[num];
                    }
                }
                num = instance.m_units.m_buffer[(int)((UIntPtr)num)].m_nextUnit;
                if (++num2 > 524288)
                {
                    CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                    break;
                }
            }

            if (num2 != 0)
            {
                averageMoney = totalMoney / num2;
            }

            return averageMoney;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancy", "RCS1213", Justification = "Harmony patch")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming Rules", "SA1313", Justification = "Harmony patch")]
        public static void PrivateBuildingAIGetColorPostFix(ushort buildingID, ref Building data, InfoManager.InfoMode infoMode, ref UnityEngine.Color __result)       {
            if (infoMode == InfoManager.InfoMode.LandValue)
            {
                ItemClass @class = data.Info.m_class;
                ItemClass.Service service = @class.m_service;
                switch (service)
                {
                    case ItemClass.Service.Residential:
                        long family_money = GetResidentialBuildingAverageMoney(buildingID, ref data);
                        if (family_money < 5000)
                            MainDataStore.building_money_threat[buildingID] = 1.0f - family_money / 10000.0f;
                        else
                            MainDataStore.building_money_threat[buildingID] = (15000.0f - family_money) / 20000.0f;

                        if (MainDataStore.building_money_threat[buildingID] < 0.5f)
                            __result =  UnityEngine.Color.Lerp(UnityEngine.Color.green, UnityEngine.Color.yellow, MainDataStore.building_money_threat[buildingID] * 2.0f);
                        else
                            __result = UnityEngine.Color.Lerp(UnityEngine.Color.yellow, UnityEngine.Color.red, (MainDataStore.building_money_threat[buildingID] - 0.5f) * 2.0f);
                        break;

                    case ItemClass.Service.Office:
                    case ItemClass.Service.Industrial:
                    case ItemClass.Service.Commercial:
                        if (MainDataStore.building_money_threat[buildingID] < 0.5f)
                            __result = UnityEngine.Color.Lerp(UnityEngine.Color.green, UnityEngine.Color.yellow, MainDataStore.building_money_threat[buildingID] * 2.0f);
                        else
                            __result = UnityEngine.Color.Lerp(UnityEngine.Color.yellow, UnityEngine.Color.red, (MainDataStore.building_money_threat[buildingID] - 0.5f) * 2.0f);
                        break;
                }
            }
        }

        public static void ProcessAdditionProductIndustrialExtractorAI(ushort buildingID, ref Building buildingData)
        {
            int deltaCustomBuffer1 = buildingData.m_customBuffer1 - MainDataStore.building_buffer1[buildingID];
            if (deltaCustomBuffer1 > 0)
            {
                if (deltaCustomBuffer1 > 500)
                {
                    deltaCustomBuffer1 = 500;
                }
                if (RealCity.reduceVehicle)
                {
                    if (!Singleton<SimulationManager>.instance.m_isNightTime)
                    {
                        //NightTime 2x , reduceVehicle 1/2, so do nothing
                        buildingData.m_customBuffer1 = (ushort)(buildingData.m_customBuffer1 - deltaCustomBuffer1 + (deltaCustomBuffer1 / (float)MainDataStore.reduceCargoDiv));
                    }
                    else
                    {
                        buildingData.m_customBuffer1 = (ushort)(buildingData.m_customBuffer1 - deltaCustomBuffer1 + (deltaCustomBuffer1 / (float)MainDataStore.reduceCargoDiv) * 2f);
                    }
                }
                else
                {
                    if (Singleton<SimulationManager>.instance.m_isNightTime)
                    {
                        buildingData.m_customBuffer1 = (ushort)(buildingData.m_customBuffer1 + deltaCustomBuffer1);
                    }
                }
            }
            MainDataStore.building_buffer1[buildingID] = buildingData.m_customBuffer1;
        }

        public static void ProcessAdditionProductOthers(ushort buildingID, ref Building buildingData)
        {
            float temp = GetComsumptionDivider(buildingData, buildingID);
            int deltaCustomBuffer1 = MainDataStore.building_buffer1[buildingID] - buildingData.m_customBuffer1;
            if (deltaCustomBuffer1 > 0)
            {
                if (deltaCustomBuffer1 > 500)
                {
                    deltaCustomBuffer1 = 500;
                }

                if (RealCity.reduceVehicle)
                {
                    buildingData.m_customBuffer1 = (ushort)(buildingData.m_customBuffer1 + deltaCustomBuffer1 - (int)(deltaCustomBuffer1 / (temp * MainDataStore.reduceCargoDiv)));
                }
                else
                {
                    buildingData.m_customBuffer1 = (ushort)(buildingData.m_customBuffer1 + deltaCustomBuffer1 - (int)(deltaCustomBuffer1 / temp));
                }
            }
            MainDataStore.building_buffer1[buildingID] = buildingData.m_customBuffer1;

            int deltaCustomBuffer2 = buildingData.m_customBuffer2 - MainDataStore.building_buffer2[buildingID];
            if (deltaCustomBuffer2 > 0)
            {
                if (deltaCustomBuffer2 > 500)
                {
                    deltaCustomBuffer2 = 500;
                }

                if (RealCity.reduceVehicle)
                {
                    if (!Singleton<SimulationManager>.instance.m_isNightTime)
                    {
                        //NightTime 2x , reduceVehicle 1/2, so do nothing
                        buildingData.m_customBuffer2 = (ushort)(buildingData.m_customBuffer2 - deltaCustomBuffer2 + (deltaCustomBuffer2 / (float)MainDataStore.reduceCargoDiv));
                    }
                    else
                    {
                        buildingData.m_customBuffer2 = (ushort)(buildingData.m_customBuffer2 - deltaCustomBuffer2 + (deltaCustomBuffer2 / (float)MainDataStore.reduceCargoDiv) * 2f);
                    }
                }
                else
                {
                    if (Singleton<SimulationManager>.instance.m_isNightTime)
                    {
                        buildingData.m_customBuffer2 = (ushort)(buildingData.m_customBuffer2 + deltaCustomBuffer2);
                    }
                }
            }
            MainDataStore.building_buffer2[buildingID] = buildingData.m_customBuffer2;
        }

        public static void ProcessAdditionProduct(ushort buildingID, ref Building buildingData)
        {
            if (buildingData.Info.m_class.m_service == ItemClass.Service.Commercial || buildingData.Info.m_class.m_service == ItemClass.Service.Industrial)
            {
                if (buildingData.Info.m_buildingAI is IndustrialExtractorAI)
                {
                    ProcessAdditionProductIndustrialExtractorAI(buildingID, ref buildingData);
                }
                else
                {
                    ProcessAdditionProductOthers(buildingID, ref buildingData);
                }
            }
        }

        public static string GetProductionType(bool isSelling, ushort buildingID, Building data)
        {
            string material = "";
            if (!isSelling)
            {
                if (data.Info.m_buildingAI is IndustrialExtractorAI)
                {
                }
                else
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.CommercialHigh:
                        case ItemClass.SubService.CommercialLow:
                        case ItemClass.SubService.CommercialEco:
                        case ItemClass.SubService.CommercialLeisure:
                        case ItemClass.SubService.CommercialTourist:
                            CommercialBuildingAI commercialBuildingAI = data.Info.m_buildingAI as CommercialBuildingAI;
                            switch (commercialBuildingAI.m_incomingResource)
                            {
                                case TransferManager.TransferReason.Goods:
                                    material = Localization.Get("PREGOODS") + Localization.Get("LUXURY_PRODUCTS"); break;
                                case TransferManager.TransferReason.Food:
                                    material = Localization.Get("FOOD") + Localization.Get("LUXURY_PRODUCTS"); break;
                                case TransferManager.TransferReason.Petrol:
                                    material = Localization.Get("PETROL"); break;
                                case TransferManager.TransferReason.Lumber:
                                    material = Localization.Get("LUMBER"); break;
                                case TransferManager.TransferReason.Logs:
                                    material = Localization.Get("LOG"); break;
                                case TransferManager.TransferReason.Oil:
                                    material = Localization.Get("OIL"); break;
                                case TransferManager.TransferReason.Ore:
                                    material = Localization.Get("ORE"); break;
                                case TransferManager.TransferReason.Grain:
                                    material = Localization.Get("GRAIN_MEAT"); break;
                                default: break;
                            }
                            break;
                        case ItemClass.SubService.IndustrialForestry:
                        case ItemClass.SubService.IndustrialFarming:
                        case ItemClass.SubService.IndustrialOil:
                        case ItemClass.SubService.IndustrialOre:
                            TransferManager.TransferReason tempReason2 = RealCityIndustrialBuildingAI.GetIncomingTransferReason(buildingID);
                            switch (tempReason2)
                            {
                                case TransferManager.TransferReason.Grain:
                                    material = Localization.Get("GRAIN_MEAT"); break;
                                case TransferManager.TransferReason.Logs:
                                    material = Localization.Get("LOG"); break;
                                case TransferManager.TransferReason.Ore:
                                    material = Localization.Get("ORE"); break;
                                case TransferManager.TransferReason.Oil:
                                    material = Localization.Get("OIL"); break;
                                default: break;
                            }
                            break;
                        case ItemClass.SubService.IndustrialGeneric:
                            TransferManager.TransferReason tempReason = RealCityIndustrialBuildingAI.GetIncomingTransferReason(buildingID);
                            TransferManager.TransferReason tempReason1 = RealCityIndustrialBuildingAI.GetSecondaryIncomingTransferReason(buildingID);
                            switch (tempReason)
                            {
                                case TransferManager.TransferReason.Food:
                                    material = Localization.Get("FOOD"); break;
                                case TransferManager.TransferReason.Lumber:
                                    material = Localization.Get("LUMBER"); break;
                                case TransferManager.TransferReason.Petrol:
                                    material = Localization.Get("PETROL"); break;
                                case TransferManager.TransferReason.Coal:
                                    material = Localization.Get("COAL"); break;
                                default: break;
                            }
                            switch (tempReason1)
                            {
                                case TransferManager.TransferReason.AnimalProducts:
                                    material += Localization.Get("ANIMALPRODUCTS"); break;
                                case TransferManager.TransferReason.Flours:
                                    material += Localization.Get("FLOURS"); break;
                                case TransferManager.TransferReason.Paper:
                                    material += Localization.Get("PAPER"); break;
                                case TransferManager.TransferReason.PlanedTimber:
                                    material += Localization.Get("PLANEDTIMBER"); break;
                                case TransferManager.TransferReason.Petroleum:
                                    material += Localization.Get("PETROLEUM"); break;
                                case TransferManager.TransferReason.Plastics:
                                    material += Localization.Get("PLASTICS"); break;
                                case TransferManager.TransferReason.Glass:
                                    material += Localization.Get("GLASS"); break;
                                case TransferManager.TransferReason.Metals:
                                    material += Localization.Get("METALS"); break;
                                default: break;
                            }
                            break;
                        default:
                            material = ""; break;
                    }
                }
            }
            else
            {
                if (data.Info.m_buildingAI is IndustrialExtractorAI)
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.IndustrialForestry:
                            material = Localization.Get("LOG"); break;
                        case ItemClass.SubService.IndustrialFarming:
                            material = Localization.Get("GRAIN_MEAT"); break;
                        case ItemClass.SubService.IndustrialOil:
                            material = Localization.Get("OIL"); break;
                        case ItemClass.SubService.IndustrialOre:
                            material = Localization.Get("ORE"); break;
                        default:
                            material = ""; break;
                    }
                }
                else
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.IndustrialForestry:
                            material = Localization.Get("LUMBER"); break;
                        case ItemClass.SubService.IndustrialFarming:
                            material = Localization.Get("FOOD"); break;
                        case ItemClass.SubService.IndustrialOil:
                            material = Localization.Get("PETROL"); break;
                        case ItemClass.SubService.IndustrialOre:
                            material = Localization.Get("COAL"); break;
                        case ItemClass.SubService.IndustrialGeneric:
                            material = Localization.Get("PREGOODS"); break;
                        case ItemClass.SubService.CommercialHigh:
                        case ItemClass.SubService.CommercialLow:
                        case ItemClass.SubService.CommercialEco:
                        case ItemClass.SubService.CommercialLeisure:
                        case ItemClass.SubService.CommercialTourist:
                            material = Localization.Get("GOODS"); break;
                        default:
                            material = ""; break;
                    }
                }
            }
            return material;
        }

        public static float GetPrice(bool isSelling, ushort buildingID, Building data)
        {
            float price = 0f;
            if (!isSelling)
            {
                if (!(data.Info.m_buildingAI is IndustrialExtractorAI))
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.CommercialHigh:
                        case ItemClass.SubService.CommercialLow:
                        case ItemClass.SubService.CommercialEco:
                        case ItemClass.SubService.CommercialLeisure:
                        case ItemClass.SubService.CommercialTourist:
                            CommercialBuildingAI commercialBuildingAI = data.Info.m_buildingAI as CommercialBuildingAI;
                            if (commercialBuildingAI.m_incomingResource == TransferManager.TransferReason.Food || commercialBuildingAI.m_incomingResource == TransferManager.TransferReason.Goods)
                            {
                                price = (3f * RealCityIndustryBuildingAI.GetResourcePrice(commercialBuildingAI.m_incomingResource) + (RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.LuxuryProducts))) / 4f;
                            }
                            else
                            {
                                price = RealCityIndustryBuildingAI.GetResourcePrice(commercialBuildingAI.m_incomingResource);
                            }
                            break;
                        case ItemClass.SubService.IndustrialForestry:
                        case ItemClass.SubService.IndustrialFarming:
                        case ItemClass.SubService.IndustrialOil:
                        case ItemClass.SubService.IndustrialOre:
                            TransferManager.TransferReason tempReason = RealCityIndustrialBuildingAI.GetIncomingTransferReason(buildingID);
                            price = RealCityIndustryBuildingAI.GetResourcePrice(tempReason);
                            break;
                        case ItemClass.SubService.IndustrialGeneric:
                            TransferManager.TransferReason tempReason1 = RealCityIndustrialBuildingAI.GetIncomingTransferReason(buildingID);
                            TransferManager.TransferReason tempReason2 = RealCityIndustrialBuildingAI.GetSecondaryIncomingTransferReason(buildingID);
                            price = (3f * RealCityIndustryBuildingAI.GetResourcePrice(tempReason1) + (RealCityIndustryBuildingAI.GetResourcePrice(tempReason2))) / 4f;
                            break;
                        default:
                            price = 0; break;
                    }
                }
            }
            else
            {
                if (data.Info.m_buildingAI is IndustrialExtractorAI)
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.IndustrialForestry:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Logs); break;
                        case ItemClass.SubService.IndustrialFarming:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Grain); break;
                        case ItemClass.SubService.IndustrialOil:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Oil); break;
                        case ItemClass.SubService.IndustrialOre:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Ore); break;
                        default:
                            price = 0; break;
                    }
                }
                else
                {
                    switch (data.Info.m_class.m_subService)
                    {
                        case ItemClass.SubService.IndustrialForestry:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Lumber); break;
                        case ItemClass.SubService.IndustrialFarming:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Food); break;
                        case ItemClass.SubService.IndustrialOil:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Petrol); break;
                        case ItemClass.SubService.IndustrialOre:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Coal); break;
                        case ItemClass.SubService.IndustrialGeneric:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Goods); break;
                        case ItemClass.SubService.CommercialHigh:
                        case ItemClass.SubService.CommercialLow:
                        case ItemClass.SubService.CommercialEco:
                        case ItemClass.SubService.CommercialLeisure:
                        case ItemClass.SubService.CommercialTourist:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.Shopping); break;
                        default:
                            price = RealCityIndustryBuildingAI.GetResourcePrice(TransferManager.TransferReason.None); break;
                    }
                }
            }
            return price;
        }

        public static void GetWorkBehaviour(ushort buildingID, ref Building buildingData, ref Citizen.BehaviourData behaviour, ref int aliveCount, ref int totalCount)
        {
            CitizenManager instance = Singleton<CitizenManager>.instance;
            uint num = buildingData.m_citizenUnits;
            int num2 = 0;
            while (num != 0u)
            {
                if ((ushort)(instance.m_units.m_buffer[(int)((UIntPtr)num)].m_flags & CitizenUnit.Flags.Work) != 0)
                {
                    instance.m_units.m_buffer[(int)((UIntPtr)num)].GetCitizenWorkBehaviour(ref behaviour, ref aliveCount, ref totalCount);
                }
                num = instance.m_units.m_buffer[(int)((UIntPtr)num)].m_nextUnit;
                if (++num2 > 524288)
                {
                    CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                    break;
                }
            }
        }
        
        public static void ProcessBuildingDataFinal(ushort buildingID, ref Building buildingData)
        {
            if (preBuidlingId > buildingID)
            {
                allOfficeHighTechBuildingCountFinal = allOfficeHighTechBuildingCount;
                allOfficeLevel1BuildingCountFinal = allOfficeLevel1BuildingCount;
                allOfficeLevel2BuildingCountFinal = allOfficeLevel2BuildingCount;
                allOfficeLevel3BuildingCountFinal = allOfficeLevel3BuildingCount;
                profitBuildingCountFinal = profitBuildingCount;
                profitBuildingMoneyFinal = profitBuildingMoney;
                allBuildingsFinal = allBuildings;
                profitBuildingMoney = 0;
                profitBuildingCount = 0;
                allOfficeLevel1BuildingCount = 0;
                allOfficeLevel2BuildingCount = 0;
                allOfficeLevel3BuildingCount = 0;
                allOfficeHighTechBuildingCount = 0;
                allBuildings = 0;
            }
            preBuidlingId = buildingID;
            allBuildings++;
            if (buildingData.Info.m_class.m_service == ItemClass.Service.Residential)
            {
                MainDataStore.building_money[buildingID] = 0;
            }

            float building_money = MainDataStore.building_money[buildingID];

            if (buildingData.Info.m_class.m_service == ItemClass.Service.Industrial)
            {
                if (building_money < 0)
                    RealCityEconomyExtension.industrialLackMoneyCount++;
                else
                    RealCityEconomyExtension.industrialEarnMoneyCount++;
            }

            if (building_money < 0)
                MainDataStore.building_money_threat[buildingID] = 1.0f;

            switch (buildingData.Info.m_class.m_service)
            {
                case ItemClass.Service.Residential:
                    break;

                case ItemClass.Service.Commercial:
                case ItemClass.Service.Industrial:
                    int num = 0; int num1 = 0;
                    float averageBuildingSalary = BuildingUI.CaculateEmployeeOutcome(buildingData, buildingID, out num, out num1);

                    if (MainDataStore.citizenCount > 0.0)
                    {
                        float averageCitySalary = MainDataStore.citizenSalaryTotal / MainDataStore.citizenCount;
                        float salaryFactor = averageBuildingSalary / averageCitySalary;
                        if (salaryFactor > 1.6f)
                            salaryFactor = 1.6f;
                        else if (salaryFactor < 0.0f)
                            salaryFactor = 0.0f;

                        MainDataStore.building_money_threat[buildingID] = (1.0f - salaryFactor / 1.6f);
                    }
                    else
                        MainDataStore.building_money_threat[buildingID] = 1.0f;

                    break;
            }

            if (buildingData.Info.m_class.m_service == ItemClass.Service.Commercial)
            {
                if (MainDataStore.building_money[buildingID] < 0)
                {
                    RealCityEconomyExtension.commericalLackMoneyCount++;
                }
                else
                {
                    RealCityEconomyExtension.commericalEarnMoneyCount++;
                }
            }

            if (buildingData.m_problems == Notification.Problem.None)
            {
                //mark no good
                if ((buildingData.Info.m_class.m_service == ItemClass.Service.Commercial) && (RealCity.debugMode))
                {
                    Notification.Problem problem = Notification.RemoveProblems(buildingData.m_problems, Notification.Problem.NoGoods);
                    if (buildingData.m_customBuffer2 < 500)
                    {
                        problem = Notification.AddProblems(problem, Notification.Problem.NoGoods | Notification.Problem.MajorProblem);
                    }
                    else if (buildingData.m_customBuffer2 < 1000)
                    {
                        problem = Notification.AddProblems(problem, Notification.Problem.NoGoods);
                    }
                    else
                    {
                        problem = Notification.Problem.None;
                    }
                    buildingData.m_problems = problem;
                }
            }
        }

        public static void LimitAndCheckBuildingMoney(Building building, ushort buildingID)
        {
            if (MainDataStore.building_money[buildingID] > 60000000)
            {
                MainDataStore.building_money[buildingID] = 60000000;
            }
            else if (MainDataStore.building_money[buildingID] < -60000000)
            {
                MainDataStore.building_money[buildingID] = -60000000;
            }

            if (MainDataStore.building_money[buildingID] > 0)
            {
                if (building.Info.m_class.m_service == ItemClass.Service.Industrial || building.Info.m_class.m_service == ItemClass.Service.Commercial)
                {
                    if (!(building.Info.m_buildingAI is IndustrialExtractorAI))
                    {
                        profitBuildingCount++;
                        float bossTake = 0;
                        float investToOffice = 0;
                        // boss take and return to office
                        if (building.Info.m_class.m_subService != ItemClass.SubService.IndustrialGeneric  && building.Info.m_class.m_subService != ItemClass.SubService.CommercialHigh && building.Info.m_class.m_subService != ItemClass.SubService.CommercialLow)
                        {
                            if (building.Info.m_class.m_subService == ItemClass.SubService.CommercialLeisure || building.Info.m_class.m_subService == ItemClass.SubService.CommercialTourist)
                            {
                                investToOffice = 0.005f;
                            } else
                            {
                                investToOffice = 0.001f;
                            }
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                        {
                            investToOffice = 0.002f;
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                        {
                            investToOffice = 0.003f;
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                        {
                            investToOffice = 0.004f;
                        }
                        // Boss will to take 
                        if (building.Info.m_class.m_subService != ItemClass.SubService.IndustrialGeneric && building.Info.m_class.m_subService != ItemClass.SubService.CommercialHigh && building.Info.m_class.m_subService != ItemClass.SubService.CommercialLow)
                        {
                            if (building.Info.m_class.m_subService == ItemClass.SubService.CommercialLeisure || building.Info.m_class.m_subService == ItemClass.SubService.CommercialTourist)
                            {
                                bossTake = 0.01f;
                            }
                            else
                            {
                                bossTake = 0.002f;
                            }
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                        {
                            bossTake = 0.004f;
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                        {
                            bossTake = 0.006f;
                        }
                        else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                        {
                            bossTake = 0.008f;
                        }

                        profitBuildingMoney += (long)(MainDataStore.building_money[buildingID] * investToOffice);
                        MainDataStore.building_money[buildingID] -= (long)(MainDataStore.building_money[buildingID] * bossTake);
                    }
                }
            }

            if (building.Info.m_class.m_service == ItemClass.Service.Office)
            {
                if (building.Info.m_class.m_subService == ItemClass.SubService.OfficeGeneric)
                {
                    if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                    {
                        if (allOfficeLevel1BuildingCountFinal > 0)
                        {
                            MainDataStore.building_money[buildingID] += profitBuildingMoneyFinal * 0.1f / allOfficeLevel1BuildingCountFinal;
                        }
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                    {
                        if (allOfficeLevel2BuildingCountFinal > 0)
                        {
                            MainDataStore.building_money[buildingID] += profitBuildingMoneyFinal * 0.2f / allOfficeLevel2BuildingCountFinal;
                        }
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                    {
                        if (allOfficeLevel3BuildingCountFinal > 0)
                        {
                            MainDataStore.building_money[buildingID] += profitBuildingMoneyFinal * 0.3f / allOfficeLevel3BuildingCountFinal;
                        }
                    }
                }
                else if (building.Info.m_class.m_subService == ItemClass.SubService.OfficeHightech)
                {
                    if (allOfficeHighTechBuildingCountFinal > 0)
                    {
                        MainDataStore.building_money[buildingID] += profitBuildingMoneyFinal * 0.4f / allOfficeHighTechBuildingCountFinal;
                    }
                }
            }
        }

        public static void ProcessLandFee(Building building, ushort buildingID)
        {
            DistrictManager instance = Singleton<DistrictManager>.instance;
            byte district = instance.GetDistrict(building.m_position);
            DistrictPolicies.Services servicePolicies = instance.m_districts.m_buffer[district].m_servicePolicies;
            DistrictPolicies.Taxation taxationPolicies = instance.m_districts.m_buffer[district].m_taxationPolicies;
            DistrictPolicies.CityPlanning cityPlanningPolicies = instance.m_districts.m_buffer[district].m_cityPlanningPolicies;

            int num = 0;
            GetLandRent(out num, building);
            int num2;
            num2 = Singleton<EconomyManager>.instance.GetTaxRate(building.Info.m_class, taxationPolicies);
            if (MainDataStore.building_money[buildingID] <= 0)
            {
                num2 = 0;
            }
            if (((taxationPolicies & DistrictPolicies.Taxation.DontTaxLeisure) != DistrictPolicies.Taxation.None) && (building.Info.m_class.m_subService == ItemClass.SubService.CommercialLeisure))
            {
                num = 0;
            }
            num = (int)(num * ((float)(instance.m_districts.m_buffer[district].GetLandValue() + 50) / 100));
            if ((building.Info.m_class.m_service == ItemClass.Service.Commercial) || (building.Info.m_class.m_service == ItemClass.Service.Industrial) || (building.Info.m_class.m_service == ItemClass.Service.Office))
            {
                MainDataStore.building_money[buildingID] = (MainDataStore.building_money[buildingID] - (float)(num * num2) / 100);
            }
            if (instance.IsPolicyLoaded(DistrictPolicies.Policies.ExtraInsulation))
            {
                if ((servicePolicies & DistrictPolicies.Services.ExtraInsulation) != DistrictPolicies.Services.None)
                {
                    num = num * 95 / 100;
                }
            }
            if ((servicePolicies & DistrictPolicies.Services.Recycling) != DistrictPolicies.Services.None)
            {
                num = num * 95 / 100;
            }

            Singleton<EconomyManager>.instance.AddPrivateIncome(num, building.Info.m_class.m_service, building.Info.m_class.m_subService, building.Info.m_class.m_level, num2 * 100);
        }

        public static void GetLandRent(out int incomeAccumulation, Building building)
        {
            ItemClass @class = building.Info.m_class;
            incomeAccumulation = 0;
            ItemClass.SubService subService = @class.m_subService;
            switch (subService)
            {
                case ItemClass.SubService.OfficeHightech:
                    incomeAccumulation = (MainDataStore.office_high_tech);
                    allOfficeHighTechBuildingCount++;
                    break;
                case ItemClass.SubService.OfficeGeneric:
                    if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                    {
                        incomeAccumulation = (MainDataStore.office_gen_levell);
                        allOfficeLevel1BuildingCount++;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                    {
                        incomeAccumulation = (MainDataStore.office_gen_level2);
                        allOfficeLevel2BuildingCount++;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                    {
                        incomeAccumulation = (MainDataStore.office_gen_level3);
                        allOfficeLevel3BuildingCount++;
                    }
                    break;
                case ItemClass.SubService.IndustrialFarming:
                    incomeAccumulation = MainDataStore.indu_farm;
                    break;
                case ItemClass.SubService.IndustrialForestry:
                    incomeAccumulation = MainDataStore.indu_forest;
                    break;
                case ItemClass.SubService.IndustrialOil:
                    incomeAccumulation = MainDataStore.indu_oil;
                    break;
                case ItemClass.SubService.IndustrialOre:
                    incomeAccumulation = MainDataStore.indu_ore;
                    break;
                case ItemClass.SubService.IndustrialGeneric:
                    if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                    {
                        incomeAccumulation = MainDataStore.indu_gen_level1;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                    {
                        incomeAccumulation = MainDataStore.indu_gen_level2;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                    {
                        incomeAccumulation = MainDataStore.indu_gen_level3;
                    }
                    break;
                case ItemClass.SubService.CommercialHigh:
                    if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                    {
                        incomeAccumulation = MainDataStore.comm_high_level1;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                    {
                        incomeAccumulation = MainDataStore.comm_high_level2;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                    {
                        incomeAccumulation = MainDataStore.comm_high_level3;
                    }
                    break;
                case ItemClass.SubService.CommercialLow:
                    if (building.Info.m_class.m_level == ItemClass.Level.Level1)
                    {
                        incomeAccumulation = MainDataStore.comm_low_level1;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level2)
                    {
                        incomeAccumulation = MainDataStore.comm_low_level2;
                    }
                    else if (building.Info.m_class.m_level == ItemClass.Level.Level3)
                    {
                        incomeAccumulation = MainDataStore.comm_low_level3;
                    }
                    break;
                case ItemClass.SubService.CommercialLeisure:
                    incomeAccumulation = MainDataStore.comm_leisure;
                    break;
                case ItemClass.SubService.CommercialTourist:
                    incomeAccumulation = MainDataStore.comm_tourist;
                    break;
                case ItemClass.SubService.CommercialEco:
                    incomeAccumulation = MainDataStore.comm_eco;
                    break;
                default: break;
            }
        }

        public static int GetTaxRate(Building data, ushort buildingID)
        {
            if (data.Info.m_class.m_service == ItemClass.Service.Commercial)
            {
                return Politics.commericalTax;
            }
            else if (data.Info.m_class.m_service == ItemClass.Service.Industrial)
            {
                if (data.Info.m_buildingAI is IndustrialExtractorAI)
                {
                    return Politics.industryTax + 60 ;
                }
                else
                {
                    return Politics.industryTax;
                }
            }

            return 0;
        }

        public static float GetComsumptionDivider(Building data, ushort buildingID)
        {
            if (data.Info.m_class.m_service == ItemClass.Service.Office)
            {
                return 0f;
            }

            Citizen.BehaviourData behaviourData = default(Citizen.BehaviourData);
            int aliveWorkerCount = 0;
            int totalWorkerCount = 0;
            BuildingUI.GetWorkBehaviour(buildingID, ref data, ref behaviourData, ref aliveWorkerCount, ref totalWorkerCount);
            float finalIdex = aliveWorkerCount / 10f;

            if (finalIdex < 1f)
            {
                finalIdex = 1f;
            }

            if (data.Info.m_class.m_subService == ItemClass.SubService.IndustrialGeneric)
            {
                Randomizer randomizer = new Randomizer(buildingID);
                int temp = randomizer.Int32(4u);
                //petrol related
                if (temp == 2)
                {
                    finalIdex = finalIdex * 1.5f / 4f;
                } else if (temp == 3)
                {
                    finalIdex = finalIdex * 1.25f / 4f;
                }
                else
                {
                    finalIdex = finalIdex / 4f;
                }
            }

            return finalIdex;
        }
    }
}
