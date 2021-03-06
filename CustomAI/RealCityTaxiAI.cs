﻿using ColossalFramework;
using RealCity.Util;
using System;
using UnityEngine;

namespace RealCity.CustomAI
{
    public class RealCityTaxiAI:TaxiAI
    {
        private void UnloadPassengers(ushort vehicleID, ref Vehicle data, ref TransportPassengerData passengerData)
        {
            CitizenManager instance = Singleton<CitizenManager>.instance;
            Vector3 lastFramePosition = data.GetLastFramePosition();
            int num = 0;
            uint num2 = data.m_citizenUnits;
            int num3 = 0;
            while (num2 != 0u)
            {
                uint nextUnit = instance.m_units.m_buffer[(int)((UIntPtr)num2)].m_nextUnit;
                for (int i = 0; i < 5; i++)
                {
                    uint citizen = instance.m_units.m_buffer[(int)((UIntPtr)num2)].GetCitizen(i);
                    if (citizen != 0u)
                    {
                        ushort instance2 = instance.m_citizens.m_buffer[(int)((UIntPtr)citizen)].m_instance;
                        if (instance2 != 0)
                        {
                            Vector3 lastFramePosition2 = instance.m_instances.m_buffer[instance2].GetLastFramePosition();
                            CitizenInfo info = instance.m_instances.m_buffer[instance2].Info;
                            info.m_citizenAI.SetCurrentVehicle(instance2, ref instance.m_instances.m_buffer[instance2], 0, 0u, data.m_targetPos0);
                            int num4 = Mathf.RoundToInt(m_transportInfo.m_ticketPrice * Vector3.Distance(lastFramePosition2, lastFramePosition) * 0.001f);
                            //new added begin
                            if (num4 != 0)
                            {
                                //DebugLog.LogToFileOnly("UnloadPassengers ticketPrice pre = " + num4.ToString());
                                CitizenManager instance3 = Singleton<CitizenManager>.instance;
                                ushort homeBuilding = instance3.m_citizens.m_buffer[(int)((UIntPtr)citizen)].m_homeBuilding;
                                BuildingManager instance4 = Singleton<BuildingManager>.instance;
                                if ((Singleton<CitizenManager>.instance.m_citizens.m_buffer[citizen].m_flags & Citizen.Flags.Tourist) == Citizen.Flags.None)
                                {
                                    MainDataStore.citizenMoney[citizen] -= (num4);
                                }
                                else
                                {
                                    if (MainDataStore.citizenMoney[citizen] < num4)
                                    {
                                        num4 = (MainDataStore.citizenMoney[citizen] > 0) ? (int)MainDataStore.citizenMoney[citizen] + 1 : 1;
                                        MainDataStore.citizenMoney[citizen] = (MainDataStore.citizenMoney[citizen] - (num4) - 1);
                                    }
                                }
                                Singleton<EconomyManager>.instance.AddResource(EconomyManager.Resource.PublicIncome, num4, m_info.m_class);
                            }
                            //new added end
                            num++;
                            if ((instance.m_citizens.m_buffer[(int)((UIntPtr)citizen)].m_flags & Citizen.Flags.Tourist) != Citizen.Flags.None)
                            {
                                passengerData.m_touristPassengers.m_tempCount = passengerData.m_touristPassengers.m_tempCount + 1u;
                            }
                            else
                            {
                                passengerData.m_residentPassengers.m_tempCount = passengerData.m_residentPassengers.m_tempCount + 1u;
                            }
                            switch (Citizen.GetAgeGroup(instance.m_citizens.m_buffer[(int)((UIntPtr)citizen)].Age))
                            {
                                case Citizen.AgeGroup.Child:
                                    passengerData.m_childPassengers.m_tempCount = passengerData.m_childPassengers.m_tempCount + 1u;
                                    break;
                                case Citizen.AgeGroup.Teen:
                                    passengerData.m_teenPassengers.m_tempCount = passengerData.m_teenPassengers.m_tempCount + 1u;
                                    break;
                                case Citizen.AgeGroup.Young:
                                    passengerData.m_youngPassengers.m_tempCount = passengerData.m_youngPassengers.m_tempCount + 1u;
                                    break;
                                case Citizen.AgeGroup.Adult:
                                    passengerData.m_adultPassengers.m_tempCount = passengerData.m_adultPassengers.m_tempCount + 1u;
                                    break;
                                case Citizen.AgeGroup.Senior:
                                    passengerData.m_seniorPassengers.m_tempCount = passengerData.m_seniorPassengers.m_tempCount + 1u;
                                    break;
                            }
                        }
                    }
                }
                num2 = nextUnit;
                if (++num3 > 524288)
                {
                    CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                    break;
                }
            }
            StatisticBase statisticBase = Singleton<StatisticsManager>.instance.Acquire<StatisticArray>(StatisticType.PassengerCount);
            statisticBase.Acquire<StatisticInt32>((int)m_transportInfo.m_transportType, 10).Add(num);
        }
    }
}
