﻿using System;
using System.Reflection;
using ColossalFramework;
using RealCity.Util;

namespace RealCity.CustomManager
{
    public class RealCityEconomyManager
    {
        public static float Road = 0f;
        public static float Electricity = 0f;
        public static float Water = 0f;
        public static float Beautification = 0f;
        public static float Garbage = 0f;
        public static float HealthCare = 0f;
        public static float PoliceDepartment = 0f;
        public static float Education = 0f;
        public static float Monument = 0f;
        public static float FireDepartment = 0f;
        public static float PublicTransport = 0f;
        public static float Policy_cost = 0f;
        public static float Disaster = 0f;
        public static float PlayerIndustry = 0f;
        public static float citizen_income = 0f;
        public static float tourist_income = 0f;
        public static float resident_low_level1_tax_income = 0f;
        public static float resident_low_level2_tax_income = 0f;
        public static float resident_low_level3_tax_income = 0f;
        public static float resident_low_level4_tax_income = 0f;
        public static float resident_low_level5_tax_income = 0f;
        public static float resident_low_eco_level1_tax_income = 0f;
        public static float resident_low_eco_level2_tax_income = 0f;
        public static float resident_low_eco_level3_tax_income = 0f;
        public static float resident_low_eco_level4_tax_income = 0f;
        public static float resident_low_eco_level5_tax_income = 0f;
        public static float resident_high_level1_tax_income = 0f;
        public static float resident_high_level2_tax_income = 0f;
        public static float resident_high_level3_tax_income = 0f;
        public static float resident_high_level4_tax_income = 0f;
        public static float resident_high_level5_tax_income = 0f;
        public static float resident_high_eco_level1_tax_income = 0f;
        public static float resident_high_eco_level2_tax_income = 0f;
        public static float resident_high_eco_level3_tax_income = 0f;
        public static float resident_high_eco_level4_tax_income = 0f;
        public static float resident_high_eco_level5_tax_income = 0f;
        public static float commerical_low_level1_income = 0f;
        public static float commerical_low_level2_income = 0f;
        public static float commerical_low_level3_income = 0f;
        public static float commerical_high_level1_income = 0f;
        public static float commerical_high_level2_income = 0f;
        public static float commerical_high_level3_income = 0f;
        public static float commerical_lei_income = 0f;
        public static float commerical_tou_income = 0f;
        public static float commerical_eco_income = 0f;
        public static float industy_forest_income = 0f;
        public static float industy_farm_income = 0f;
        public static float industy_oil_income = 0f;
        public static float industy_ore_income = 0f;
        public static float industy_gen_level1_income = 0f;
        public static float industy_gen_level2_income = 0f;
        public static float industy_gen_level3_income = 0f;
        public static float office_gen_level1_income = 0f;
        public static float office_gen_level2_income = 0f;
        public static float office_gen_level3_income = 0f;
        public static float office_high_tech_income = 0f;
        public static float resident_low_level1_income = 0f;
        public static float resident_low_level2_income = 0f;
        public static float resident_low_level3_income = 0f;
        public static float resident_low_level4_income = 0f;
        public static float resident_low_level5_income = 0f;
        public static float resident_low_eco_level1_income = 0f;
        public static float resident_low_eco_level2_income = 0f;
        public static float resident_low_eco_level3_income = 0f;
        public static float resident_low_eco_level4_income = 0f;
        public static float resident_low_eco_level5_income = 0f;
        public static float resident_high_level1_income = 0f;
        public static float resident_high_level2_income = 0f;
        public static float resident_high_level3_income = 0f;
        public static float resident_high_level4_income = 0f;
        public static float resident_high_level5_income = 0f;
        public static float resident_high_eco_level1_income = 0f;
        public static float resident_high_eco_level2_income = 0f;
        public static float resident_high_eco_level3_income = 0f;
        public static float resident_high_eco_level4_income = 0f;
        public static float resident_high_eco_level5_income = 0f;
        public static float commerical_low_level1_trade_income = 0f;
        public static float commerical_low_level2_trade_income = 0f;
        public static float commerical_low_level3_trade_income = 0f;
        public static float commerical_high_level1_trade_income = 0f;
        public static float commerical_high_level2_trade_income = 0f;
        public static float commerical_high_level3_trade_income = 0f;
        public static float commerical_lei_trade_income = 0f;
        public static float commerical_tou_trade_income = 0f;
        public static float commerical_eco_trade_income = 0f;
        public static float industy_forest_trade_income = 0f;
        public static float industy_farm_trade_income = 0f;
        public static float industy_oil_trade_income = 0f;
        public static float industy_ore_trade_income = 0f;
        public static float industy_gen_level1_trade_income = 0f;
        public static float industy_gen_level2_trade_income = 0f;
        public static float industy_gen_level3_trade_income = 0f;
        //citizen tax income
        public static int[] citizen_tax_income_forui = new int[17];
        //tourist for both citizen and tourist
        public static int[] citizen_income_forui = new int[17];
        public static int[] tourist_income_forui = new int[17];
        //land income
        public static int[] resident_high_landincome_forui = new int[17];
        public static int[] resident_low_landincome_forui = new int[17];
        public static int[] resident_high_eco_landincome_forui = new int[17];
        public static int[] resident_low_eco_landincome_forui = new int[17];
        public static int[] comm_high_landincome_forui = new int[17];
        public static int[] comm_low_landincome_forui = new int[17];
        public static int[] comm_lei_landincome_forui = new int[17];
        public static int[] comm_tou_landincome_forui = new int[17];
        public static int[] comm_eco_landincome_forui = new int[17];
        public static int[] indu_gen_landincome_forui = new int[17];
        public static int[] indu_farmer_landincome_forui = new int[17];
        public static int[] indu_foresty_landincome_forui = new int[17];
        public static int[] indu_oil_landincome_forui = new int[17];
        public static int[] indu_ore_landincome_forui = new int[17];
        public static int[] office_gen_landincome_forui = new int[17];
        public static int[] office_high_tech_landincome_forui = new int[17];
        //trade income
        public static int[] comm_high_tradeincome_forui = new int[17];
        public static int[] comm_low_tradeincome_forui = new int[17];
        public static int[] comm_lei_tradeincome_forui = new int[17];
        public static int[] comm_tou_tradeincome_forui = new int[17];
        public static int[] comm_eco_tradeincome_forui = new int[17];
        public static int[] indu_gen_tradeincome_forui = new int[17];
        public static int[] indu_farmer_tradeincome_forui = new int[17];
        public static int[] indu_foresty_tradeincome_forui = new int[17];
        public static int[] indu_oil_tradeincome_forui = new int[17];
        public static int[] indu_ore_tradeincome_forui = new int[17];
        //govement income
        public static float garbage_income = 0f;
        public static float road_income = 0f;
        public static float playerIndustryIncome = 0f;
        public static int[] garbage_income_forui = new int[17];
        public static int[] road_income_forui = new int[17];
        public static int[] playerIndustryIncomeForUI = new int[17];
        public static float school_income = 0f;
        public static int[] school_income_forui = new int[17];
       //72*3 = 216
        public static float policeStationIncome = 0f;
        public static int[] policeStationIncomeForUI = new int[17];
        public static float healthCareIncome = 0f;
        public static int[] healthCareIncomeForUI = new int[17];
        public static float fireStationIncome = 0f;
        public static int[] fireStationIncomeForUI = new int[17];
        //2628+216 = 2844
        public static byte[] saveData = new byte[2844];

        public static void CleanCurrent(int current_idex)
        {
            int i = current_idex;
            citizen_tax_income_forui[i] = 0;
            citizen_income_forui[i] = 0;
            tourist_income_forui[i] = 0;
            resident_high_landincome_forui[i] = 0;
            resident_low_landincome_forui[i] = 0;
            resident_high_eco_landincome_forui[i] = 0;
            resident_low_eco_landincome_forui[i] = 0;
            comm_high_landincome_forui[i] = 0;
            comm_low_landincome_forui[i] = 0;
            comm_lei_landincome_forui[i] = 0;
            comm_tou_landincome_forui[i] = 0;
            comm_eco_landincome_forui[i] = 0;
            indu_gen_landincome_forui[i] = 0;
            indu_farmer_landincome_forui[i] = 0;
            indu_foresty_landincome_forui[i] = 0;
            indu_oil_landincome_forui[i] = 0;
            indu_ore_landincome_forui[i] = 0;
            office_gen_landincome_forui[i] = 0;
            office_high_tech_landincome_forui[i] = 0;
            comm_high_tradeincome_forui[i] = 0;
            comm_low_tradeincome_forui[i] = 0;
            comm_lei_tradeincome_forui[i] = 0;
            comm_tou_tradeincome_forui[i] = 0;
            comm_eco_tradeincome_forui[i] = 0;
            indu_gen_tradeincome_forui[i] = 0;
            indu_farmer_tradeincome_forui[i] = 0;
            indu_foresty_tradeincome_forui[i] = 0;
            indu_oil_tradeincome_forui[i] = 0;
            indu_ore_tradeincome_forui[i] = 0;
            garbage_income_forui[i] = 0;
            playerIndustryIncomeForUI[i] = 0;
            road_income_forui[i] = 0;
            school_income_forui[i] = 0;
            policeStationIncomeForUI[i] = 0;
            fireStationIncomeForUI[i] = 0;
            healthCareIncomeForUI[i] = 0;
        }

        public static void dataInit()
        {
            int i = 0;
            for (i = 0; i < 17; i++)
            {
                citizen_tax_income_forui[i] = 0;
                citizen_income_forui[i] = 0;
                tourist_income_forui[i] = 0;
                resident_high_landincome_forui[i] = 0;
                resident_low_landincome_forui[i] = 0;
                resident_high_eco_landincome_forui[i] = 0;
                resident_low_eco_landincome_forui[i] = 0;
                comm_high_landincome_forui[i] = 0;
                comm_low_landincome_forui[i] = 0;
                comm_lei_landincome_forui[i] = 0;
                comm_tou_landincome_forui[i] = 0;
                comm_eco_landincome_forui[i] = 0;
                indu_gen_landincome_forui[i] = 0;
                indu_farmer_landincome_forui[i] = 0;
                indu_foresty_landincome_forui[i] = 0;
                indu_oil_landincome_forui[i] = 0;
                indu_ore_landincome_forui[i] = 0;
                office_gen_landincome_forui[i] = 0;
                office_high_tech_landincome_forui[i] = 0;
                comm_high_tradeincome_forui[i] = 0;
                comm_low_tradeincome_forui[i] = 0;
                comm_lei_tradeincome_forui[i] = 0;
                comm_tou_tradeincome_forui[i] = 0;
                comm_eco_tradeincome_forui[i] = 0;
                indu_gen_tradeincome_forui[i] = 0;
                indu_farmer_tradeincome_forui[i] = 0;
                indu_foresty_tradeincome_forui[i] = 0;
                indu_oil_tradeincome_forui[i] = 0;
                indu_ore_tradeincome_forui[i] = 0;
                road_income_forui[i] = 0;
                playerIndustryIncomeForUI[i] = 0;
                garbage_income_forui[i] = 0;
                school_income_forui[i] = 0;
                policeStationIncomeForUI[i] = 0;
                fireStationIncomeForUI[i] = 0;
                healthCareIncomeForUI[i] = 0;
            }
        }

        public static void Load()
        {
            int i = 0;
            Road = SaveAndRestore.load_float(ref i, saveData);
            Electricity = SaveAndRestore.load_float(ref i, saveData);
            Water = SaveAndRestore.load_float(ref i, saveData);
            Beautification = SaveAndRestore.load_float(ref i, saveData);
            Garbage = SaveAndRestore.load_float(ref i, saveData);
            HealthCare = SaveAndRestore.load_float(ref i, saveData);
            PoliceDepartment = SaveAndRestore.load_float(ref i, saveData);
            Education = SaveAndRestore.load_float(ref i, saveData);
            Monument = SaveAndRestore.load_float(ref i, saveData);
            FireDepartment = SaveAndRestore.load_float(ref i, saveData);
            PublicTransport = SaveAndRestore.load_float(ref i, saveData);
            Policy_cost = SaveAndRestore.load_float(ref i, saveData);
            Disaster = SaveAndRestore.load_float(ref i, saveData);
            citizen_income = SaveAndRestore.load_float(ref i, saveData);
            tourist_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level1_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level2_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level3_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level4_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level5_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level1_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level2_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level3_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level4_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level5_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level1_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level2_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level3_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level4_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level5_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level1_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level2_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level3_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level4_tax_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level5_tax_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level1_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level2_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level3_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level1_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level2_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level3_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_lei_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_tou_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_eco_income = SaveAndRestore.load_float(ref i, saveData);
            industy_forest_income = SaveAndRestore.load_float(ref i, saveData);
            industy_farm_income = SaveAndRestore.load_float(ref i, saveData);
            industy_oil_income = SaveAndRestore.load_float(ref i, saveData);
            industy_ore_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level1_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level2_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level3_income = SaveAndRestore.load_float(ref i, saveData);
            office_gen_level1_income = SaveAndRestore.load_float(ref i, saveData);
            office_gen_level2_income = SaveAndRestore.load_float(ref i, saveData);
            office_gen_level3_income = SaveAndRestore.load_float(ref i, saveData);
            office_high_tech_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level1_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level2_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level3_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level4_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_level5_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level1_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level2_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level3_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level4_income = SaveAndRestore.load_float(ref i, saveData);
            resident_low_eco_level5_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level1_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level2_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level3_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level4_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_level5_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level1_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level2_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level3_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level4_income = SaveAndRestore.load_float(ref i, saveData);
            resident_high_eco_level5_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level1_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level2_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_low_level3_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level1_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level2_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_high_level3_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_lei_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_tou_trade_income = SaveAndRestore.load_float(ref i, saveData);
            commerical_eco_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_forest_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_farm_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_oil_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_ore_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level1_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level2_trade_income = SaveAndRestore.load_float(ref i, saveData);
            industy_gen_level3_trade_income = SaveAndRestore.load_float(ref i, saveData);
            // 97*4 = 388
            // 35*4*17 = 2768
            citizen_tax_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            citizen_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            tourist_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            resident_high_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            resident_low_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            resident_high_eco_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            resident_low_eco_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_high_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_low_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_lei_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_tou_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_eco_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_gen_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_farmer_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_foresty_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_oil_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_ore_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            office_gen_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            office_high_tech_landincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_high_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_low_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_lei_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_tou_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            comm_eco_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_gen_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_farmer_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_foresty_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_oil_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            indu_ore_tradeincome_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            road_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            playerIndustryIncomeForUI = SaveAndRestore.load_ints(ref i, saveData, 17);
            garbage_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            road_income = SaveAndRestore.load_float(ref i, saveData);
            playerIndustryIncome = SaveAndRestore.load_float(ref i, saveData);
            garbage_income = SaveAndRestore.load_float(ref i, saveData);
            school_income_forui = SaveAndRestore.load_ints(ref i, saveData, 17);
            school_income = SaveAndRestore.load_float(ref i, saveData);
            PlayerIndustry = SaveAndRestore.load_float(ref i, saveData);
            policeStationIncomeForUI = SaveAndRestore.load_ints(ref i, saveData, 17);
            policeStationIncome = SaveAndRestore.load_float(ref i, saveData);
            healthCareIncomeForUI = SaveAndRestore.load_ints(ref i, saveData, 17);
            healthCareIncome = SaveAndRestore.load_float(ref i, saveData);
            fireStationIncomeForUI = SaveAndRestore.load_ints(ref i, saveData, 17);
            fireStationIncome = SaveAndRestore.load_float(ref i, saveData);
            DebugLog.LogToFileOnly("saveData in EM is " + i.ToString());
        }

        public static void Save()
        {
            int i = 0;
            //680+1292+64+160+80+52 = 2382
            //15*4 = 60
            SaveAndRestore.save_float(ref i, Road, ref saveData);
            SaveAndRestore.save_float(ref i, Electricity, ref saveData);
            SaveAndRestore.save_float(ref i, Water, ref saveData);
            SaveAndRestore.save_float(ref i, Beautification, ref saveData);
            SaveAndRestore.save_float(ref i, Garbage, ref saveData);
            SaveAndRestore.save_float(ref i, HealthCare, ref saveData);
            SaveAndRestore.save_float(ref i, PoliceDepartment, ref saveData);
            SaveAndRestore.save_float(ref i, Education, ref saveData);
            SaveAndRestore.save_float(ref i, Monument, ref saveData);
            SaveAndRestore.save_float(ref i, FireDepartment, ref saveData);
            SaveAndRestore.save_float(ref i, PoliceDepartment, ref saveData);
            SaveAndRestore.save_float(ref i, Policy_cost, ref saveData);
            SaveAndRestore.save_float(ref i, Disaster, ref saveData);
            SaveAndRestore.save_float(ref i, citizen_income, ref saveData);
            SaveAndRestore.save_float(ref i, tourist_income, ref saveData);
            //20*4 = 80
            SaveAndRestore.save_float(ref i, resident_low_level1_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level2_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level3_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level4_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level5_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level1_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level2_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level3_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level4_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level5_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level1_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level2_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level3_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level4_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level5_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level1_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level2_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level3_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level4_tax_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level5_tax_income, ref saveData);
            //40*4 = 160
            SaveAndRestore.save_float(ref i, commerical_low_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_low_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_low_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_lei_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_tou_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_eco_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_forest_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_farm_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_oil_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_ore_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, office_gen_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, office_gen_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, office_gen_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, office_high_tech_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level4_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_level5_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level4_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_low_eco_level5_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level4_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_level5_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level1_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level2_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level3_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level4_income, ref saveData);
            SaveAndRestore.save_float(ref i, resident_high_eco_level5_income, ref saveData);
            //16*4 = 64
            SaveAndRestore.save_float(ref i, commerical_low_level1_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_low_level2_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_low_level3_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level1_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level2_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_high_level3_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_lei_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_tou_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, commerical_eco_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_forest_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_farm_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_oil_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_ore_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level1_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level2_trade_income, ref saveData);
            SaveAndRestore.save_float(ref i, industy_gen_level3_trade_income, ref saveData);
            //19*4*17 = 1292
            SaveAndRestore.save_ints(ref i, citizen_tax_income_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, citizen_income_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, tourist_income_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, resident_high_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, resident_low_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, resident_high_eco_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, resident_low_eco_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_high_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_low_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_lei_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_tou_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_eco_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_gen_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_farmer_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_foresty_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_oil_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_ore_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, office_gen_landincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, office_high_tech_landincome_forui, ref saveData);
            //10*17*4 = 680
            SaveAndRestore.save_ints(ref i, comm_high_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_low_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_lei_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_tou_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, comm_eco_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_gen_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_farmer_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_foresty_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_oil_tradeincome_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, indu_ore_tradeincome_forui, ref saveData);
            //3 * 17 * 4 = 204
            SaveAndRestore.save_ints(ref i, road_income_forui, ref saveData);
            SaveAndRestore.save_ints(ref i, playerIndustryIncomeForUI, ref saveData);
            SaveAndRestore.save_ints(ref i, garbage_income_forui, ref saveData);
            //3 * 4 = 12
            SaveAndRestore.save_float(ref i, road_income, ref saveData);
            SaveAndRestore.save_float(ref i, playerIndustryIncome, ref saveData);
            SaveAndRestore.save_float(ref i, garbage_income, ref saveData);
            //3 * 17 * 4 = 204    - 136
            SaveAndRestore.save_ints(ref i, school_income_forui, ref saveData);
            //3 * 4 = 12   - 8
            SaveAndRestore.save_float(ref i, school_income, ref saveData);
            SaveAndRestore.save_float(ref i, PlayerIndustry, ref saveData);
            SaveAndRestore.save_ints(ref i, policeStationIncomeForUI, ref saveData);
            SaveAndRestore.save_float(ref i, policeStationIncome, ref saveData);
            SaveAndRestore.save_ints(ref i, healthCareIncomeForUI, ref saveData);
            SaveAndRestore.save_float(ref i, healthCareIncome, ref saveData);
            SaveAndRestore.save_ints(ref i, fireStationIncomeForUI, ref saveData);
            SaveAndRestore.save_float(ref i, fireStationIncome, ref saveData);
        }

        public int FetchResource(EconomyManager.Resource resource, int amount, ItemClass itemClass)
        {
            int temp;
            if (resource == EconomyManager.Resource.Maintenance)
            {
                switch (itemClass.m_service)
                {
                    case ItemClass.Service.Road:
                        Road += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Road > 1)
                        {
                            temp = (int)Road;
                            Road = Road - (int)Road;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Garbage:
                        Garbage += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Garbage > 1)
                        {
                            temp = (int)Garbage;
                            Garbage = Garbage - (int)Garbage;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.PoliceDepartment:
                        PoliceDepartment += (float)amount / MainDataStore.gameExpenseDivide;
                        if (PoliceDepartment > 1)
                        {
                            temp = (int)PoliceDepartment;
                            PoliceDepartment = PoliceDepartment - (int)PoliceDepartment;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Beautification:
                        Beautification += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Beautification > 1)
                        {
                            temp = (int)Beautification;
                            Beautification = Beautification - (int)Beautification;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Water:
                        Water += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Water > 1)
                        {
                            temp = (int)Water;
                            Water = Water - (int)Water;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Education:
                        Education += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Education > 1)
                        {
                            temp = (int)Education;
                            Education = Education - (int)Education;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Electricity:
                        Electricity += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Electricity > 1)
                        {
                            temp = (int)Electricity;
                            Electricity = Electricity - (int)Electricity;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.FireDepartment:
                        FireDepartment += (float)amount / MainDataStore.gameExpenseDivide;
                        if (FireDepartment > 1)
                        {
                            temp = (int)FireDepartment;
                            FireDepartment = FireDepartment - (int)FireDepartment;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Monument:
                        Monument += amount / MainDataStore.gameExpenseDivide;
                        if (Monument > 1)
                        {
                            temp = (int)Monument;
                            Monument = Monument - (int)Monument;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.HealthCare:
                        HealthCare += (float)amount / MainDataStore.gameExpenseDivide;
                        if (HealthCare > 1)
                        {
                            temp = (int)HealthCare;
                            HealthCare = HealthCare - (int)HealthCare;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.PublicTransport:
                        PublicTransport += (float)amount / MainDataStore.gameExpenseDivide;
                        if (PublicTransport > 1)
                        {
                            temp = (int)PublicTransport;
                            PublicTransport = PublicTransport - (int)PublicTransport;
                            //if (itemClass.m_subService == ItemClass.SubService.PublicTransportPost)
                            //{
                            //    DebugLog.LogToFileOnly("post maintain fee is " + temp.ToString());
                            //}
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.Disaster:
                        Disaster += (float)amount / MainDataStore.gameExpenseDivide;
                        if (Disaster > 1)
                        {
                            temp = (int)Disaster;
                            Disaster = Disaster - (int)Disaster;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    case ItemClass.Service.PlayerIndustry:
                        PlayerIndustry += (float)amount / MainDataStore.gameExpenseDivide;
                        if (PlayerIndustry > 1)
                        {
                            temp = (int)PlayerIndustry;
                            PlayerIndustry = PlayerIndustry - (int)PlayerIndustry;
                            Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                            return amount;
                        }
                        return amount;
                    default: break;
                }
            }
            if (resource == EconomyManager.Resource.PolicyCost)
            {
                Policy_cost += (float)amount / MainDataStore.gameExpenseDivide;
                if (Policy_cost > 1)
                {
                    temp = (int)Policy_cost;
                    Policy_cost = Policy_cost - (int)Policy_cost;
                    Singleton<EconomyManager>.instance.FetchResource(resource, temp, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
                    return amount;
                }
                return amount;
            }
                return Singleton<EconomyManager>.instance.FetchResource(resource, amount, itemClass.m_service, itemClass.m_subService, itemClass.m_level);
        }

        public int EXAddGovermentIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            switch (service)
            {
                case ItemClass.Service.Garbage:
                    garbage_income += (amount * taxRate/100f);
                    if (garbage_income > 1)
                    {
                        amount = (int)garbage_income;
                        garbage_income = garbage_income - (int)garbage_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    garbage_income_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.Service.Education:
                    school_income += (amount * taxRate/100f);
                    if (school_income > 1)
                    {
                        amount = (int)school_income;
                        school_income = school_income - (int)school_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    school_income_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.Service.HealthCare:
                    healthCareIncome += (amount * taxRate / 100f);
                    if (healthCareIncome > 1)
                    {
                        amount = (int)healthCareIncome;
                        healthCareIncome = healthCareIncome - (int)healthCareIncome;
                    }
                    else
                    {
                        amount = 0;
                    }
                    healthCareIncomeForUI[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.Service.FireDepartment:
                    fireStationIncome += (amount * taxRate / 100f);
                    if (fireStationIncome > 1)
                    {
                        amount = (int)fireStationIncome;
                        fireStationIncome = fireStationIncome - (int)fireStationIncome;
                    }
                    else
                    {
                        amount = 0;
                    }
                    fireStationIncomeForUI[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.Service.PoliceDepartment:
                    policeStationIncome += (amount * taxRate / 100f);
                    if (policeStationIncome > 1)
                    {
                        amount = (int)policeStationIncome;
                        policeStationIncome = policeStationIncome - (int)policeStationIncome;
                    }
                    else
                    {
                        amount = 0;
                    }
                    policeStationIncomeForUI[MainDataStore.update_money_count] += amount;
                    break;
                default:
                    amount = 0;
                    DebugLog.LogToFileOnly("Error: Find unknown EXAddGovermentIncome building" + " service is" + service.ToString() + " subService is" + subService.ToString() + " Level is" + level.ToString() + " Tax is " + taxRate);
                    break;
            }
            return amount;
        }

        public int EXAddPersonalTaxIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            switch (subService)
            {
                case ItemClass.SubService.ResidentialHigh:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_high_level1_tax_income += (amount * taxRate/100f);
                        if (resident_high_level1_tax_income > 1)
                        {
                            amount = (int)resident_high_level1_tax_income;
                            resident_high_level1_tax_income = resident_high_level1_tax_income - (int)resident_high_level1_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_high_level2_tax_income += (amount * taxRate/100f);
                        if (resident_high_level2_tax_income > 1)
                        {
                            amount = (int)resident_high_level2_tax_income;
                            resident_high_level2_tax_income = resident_high_level2_tax_income - (int)resident_high_level2_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_high_level3_tax_income += (amount * taxRate/100f);
                        if (resident_high_level3_tax_income > 1)
                        {
                            amount = (int)resident_high_level3_tax_income;
                            resident_high_level3_tax_income = resident_high_level3_tax_income - (int)resident_high_level3_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_high_level4_tax_income += (amount * taxRate/100f);
                        if (resident_high_level4_tax_income > 1)
                        {
                            amount = (int)resident_high_level4_tax_income;
                            resident_high_level4_tax_income = resident_high_level4_tax_income - (int)resident_high_level4_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_high_level5_tax_income += (amount * taxRate/100f);
                        if (resident_high_level5_tax_income > 1)
                        {
                            amount = (int)resident_high_level5_tax_income;
                            resident_high_level5_tax_income = resident_high_level5_tax_income - (int)resident_high_level5_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    break;
                case ItemClass.SubService.ResidentialLow:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_low_level1_tax_income += (amount * taxRate/100f);
                        if (resident_low_level1_tax_income > 1)
                        {
                            amount = (int)resident_low_level1_tax_income;
                            resident_low_level1_tax_income = resident_low_level1_tax_income - (int)resident_low_level1_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_low_level2_tax_income += (amount * taxRate/100f);
                        if (resident_low_level2_tax_income > 1)
                        {
                            amount = (int)resident_low_level2_tax_income;
                            resident_low_level2_tax_income = resident_low_level2_tax_income - (int)resident_low_level2_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_low_level3_tax_income += (amount * taxRate/100f);
                        if (resident_low_level3_tax_income > 1)
                        {
                            amount = (int)resident_low_level3_tax_income;
                            resident_low_level3_tax_income = resident_low_level3_tax_income - (int)resident_low_level3_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_low_level4_tax_income += (amount * taxRate/100f);
                        if (resident_low_level4_tax_income > 1)
                        {
                            amount = (int)resident_low_level4_tax_income;
                            resident_low_level4_tax_income = resident_low_level4_tax_income - (int)resident_low_level4_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_low_level5_tax_income += (amount * taxRate/100f);
                        if (resident_low_level5_tax_income > 1)
                        {
                            amount = (int)resident_low_level5_tax_income;
                            resident_low_level5_tax_income = resident_low_level5_tax_income - (int)resident_low_level5_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    break;
                case ItemClass.SubService.ResidentialHighEco:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_high_eco_level1_tax_income += (amount * taxRate/100f);
                        if (resident_high_eco_level1_tax_income > 1)
                        {
                            amount = (int)resident_high_eco_level1_tax_income;
                            resident_high_eco_level1_tax_income = resident_high_eco_level1_tax_income - (int)resident_high_eco_level1_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_high_eco_level2_tax_income += (amount * taxRate/100f);
                        if (resident_high_eco_level2_tax_income > 1)
                        {
                            amount = (int)resident_high_eco_level2_tax_income;
                            resident_high_eco_level2_tax_income = resident_high_eco_level2_tax_income - (int)resident_high_eco_level2_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_high_eco_level3_tax_income += (amount * taxRate/100f);
                        if (resident_high_eco_level3_tax_income > 1)
                        {
                            amount = (int)resident_high_eco_level3_tax_income;
                            resident_high_eco_level3_tax_income = resident_high_eco_level3_tax_income - (int)resident_high_eco_level3_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_high_eco_level4_tax_income += (amount * taxRate/100f);
                        if (resident_high_eco_level4_tax_income > 1)
                        {
                            amount = (int)resident_high_eco_level4_tax_income;
                            resident_high_eco_level4_tax_income = resident_high_eco_level4_tax_income - (int)resident_high_eco_level4_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_high_eco_level5_tax_income += (amount * taxRate/100f);
                        if (resident_high_eco_level5_tax_income > 1)
                        {
                            amount = (int)resident_high_eco_level5_tax_income;
                            resident_high_eco_level5_tax_income = resident_high_eco_level5_tax_income - (int)resident_high_eco_level5_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    break;
                case ItemClass.SubService.ResidentialLowEco:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_low_eco_level1_tax_income += (amount * taxRate/100f);
                        if (resident_low_eco_level1_tax_income > 1)
                        {
                            amount = (int)resident_low_eco_level1_tax_income;
                            resident_low_eco_level1_tax_income = resident_low_eco_level1_tax_income - (int)resident_low_eco_level1_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_low_eco_level2_tax_income += (amount * taxRate/100f);
                        if (resident_low_eco_level2_tax_income > 1)
                        {
                            amount = (int)resident_low_eco_level2_tax_income;
                            resident_low_eco_level2_tax_income = resident_low_eco_level2_tax_income - (int)resident_low_eco_level2_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_low_eco_level3_tax_income += (amount * taxRate/100f);
                        if (resident_low_eco_level3_tax_income > 1)
                        {
                            amount = (int)resident_low_eco_level3_tax_income;
                            resident_low_eco_level3_tax_income = resident_low_eco_level3_tax_income - (int)resident_low_eco_level3_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_low_eco_level4_tax_income += (amount * taxRate/100f);
                        if (resident_low_eco_level4_tax_income > 1)
                        {
                            amount = (int)resident_low_eco_level4_tax_income;
                            resident_low_eco_level4_tax_income = resident_low_eco_level4_tax_income - (int)resident_low_eco_level4_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_low_eco_level5_tax_income += (amount * taxRate/100f);
                        if (resident_low_eco_level5_tax_income > 1)
                        {
                            amount = (int)resident_low_eco_level5_tax_income;
                            resident_low_eco_level5_tax_income = resident_low_eco_level5_tax_income - (int)resident_low_eco_level5_tax_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    break;
                default:
                    DebugLog.LogToFileOnly("find unknown  EXAddPrivateLandIncome building" + " building servise is" + service + " building subservise is" + subService + " buildlevelandtax is" + level + " " + taxRate);
                    break;
            }
            citizen_tax_income_forui[MainDataStore.update_money_count] = citizen_tax_income_forui[MainDataStore.update_money_count] + amount;
            return amount;
        }

        public int EXAddTourismIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            if (taxRate == 114)
            {
                taxRate = 100;
                citizen_income += (amount * taxRate/100f);
                if (citizen_income > 1)
                {
                    amount = (int)citizen_income;
                    citizen_income = citizen_income - (int)citizen_income;
                }
                else
                {
                    amount = 0;
                }
                citizen_income_forui[MainDataStore.update_money_count] += amount;
            }
            else
            {
                taxRate = 100;
                tourist_income += (amount * taxRate/100f);
                if (tourist_income > 1)
                {
                    amount = (int)tourist_income;
                    tourist_income = tourist_income - (int)tourist_income;
                }
                else
                {
                    amount = 0;
                }
                tourist_income_forui[MainDataStore.update_money_count] += amount;
            }
            return amount;
        }

        public int EXAddPrivateTradeIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            switch (subService)
            {
                case ItemClass.SubService.IndustrialFarming:
                    industy_farm_trade_income += (amount * taxRate/100f);
                    if (industy_farm_trade_income > 1)
                    {
                        amount = (int)industy_farm_trade_income;
                        industy_farm_trade_income = industy_farm_trade_income - (int)industy_farm_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_farmer_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialForestry:
                    industy_forest_trade_income += (amount * taxRate/100f);
                    //DebugLog.LogToFileOnly("industy_forest_trade_income = " + industy_forest_trade_income.ToString() + " " + amount.ToString());
                    if (industy_forest_trade_income > 1)
                    {
                        amount = (int)industy_forest_trade_income;
                        industy_forest_trade_income = industy_forest_trade_income - (int)industy_forest_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_foresty_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialOil:
                    industy_oil_trade_income += (amount * taxRate/100f);
                    if (industy_oil_trade_income > 1)
                    {
                        amount = (int)industy_oil_trade_income;
                        industy_oil_trade_income = industy_oil_trade_income - (int)industy_oil_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_oil_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialOre:
                    industy_ore_trade_income += (amount * taxRate/100f);
                    if (industy_ore_trade_income > 1)
                    {
                        amount = (int)industy_ore_trade_income;
                        industy_ore_trade_income = industy_ore_trade_income - (int)industy_ore_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_ore_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialGeneric:
                    if (level == ItemClass.Level.Level1)
                    {
                        industy_gen_level1_trade_income += (amount * taxRate/100f);
                        if (industy_gen_level1_trade_income > 1)
                        {
                            amount = (int)industy_gen_level1_trade_income;
                            industy_gen_level1_trade_income = industy_gen_level1_trade_income - (int)industy_gen_level1_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        industy_gen_level2_trade_income += (amount * taxRate/100f);
                        if (industy_gen_level2_trade_income > 1)
                        {
                            amount = (int)industy_gen_level2_trade_income;
                            industy_gen_level2_trade_income = industy_gen_level2_trade_income - (int)industy_gen_level2_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        industy_gen_level3_trade_income += (amount * taxRate/100f);
                        if (industy_gen_level3_trade_income > 1)
                        {
                            amount = (int)industy_gen_level3_trade_income;
                            industy_gen_level3_trade_income = industy_gen_level3_trade_income - (int)industy_gen_level3_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    indu_gen_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialHigh:
                    if (level == ItemClass.Level.Level1)
                    {
                        commerical_high_level1_trade_income += (amount * taxRate/100f);
                        if (commerical_high_level1_trade_income > 1)
                        {
                            amount = (int)commerical_high_level1_trade_income;
                            commerical_high_level1_trade_income = commerical_high_level1_trade_income - (int)commerical_high_level1_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        commerical_high_level2_trade_income += (amount * taxRate/100f);
                        if (commerical_high_level2_trade_income > 1)
                        {
                            amount = (int)commerical_high_level2_trade_income;
                            commerical_high_level2_trade_income = commerical_high_level2_trade_income - (int)commerical_high_level2_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        commerical_high_level3_trade_income += (amount * taxRate/100f);
                        if (commerical_high_level3_trade_income > 1)
                        {
                            amount = (int)commerical_high_level3_trade_income;
                            commerical_high_level3_trade_income = commerical_high_level3_trade_income - (int)commerical_high_level3_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    comm_high_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialLow:
                    if (level == ItemClass.Level.Level1)
                    {
                        commerical_low_level1_trade_income += (amount * taxRate/100f);
                        if (commerical_low_level1_trade_income > 1)
                        {
                            amount = (int)commerical_low_level1_trade_income;
                            commerical_low_level1_trade_income = commerical_low_level1_trade_income - (int)commerical_low_level1_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        commerical_low_level2_trade_income += (amount * taxRate/100f);
                        if (commerical_low_level2_trade_income > 1)
                        {
                            amount = (int)commerical_low_level2_trade_income;
                            commerical_low_level2_trade_income = commerical_low_level2_trade_income - (int)commerical_low_level2_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        commerical_low_level3_trade_income += (amount * taxRate/100f);
                        if (commerical_low_level3_trade_income > 1)
                        {
                            amount = (int)commerical_low_level3_trade_income;
                            commerical_low_level3_trade_income = commerical_low_level3_trade_income - (int)commerical_low_level3_trade_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    comm_low_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialLeisure:
                    commerical_lei_trade_income += (amount * taxRate/100f);
                    if (commerical_lei_trade_income > 1)
                    {
                        amount = (int)commerical_lei_trade_income;
                        commerical_lei_trade_income = commerical_lei_trade_income - (int)commerical_lei_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_lei_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialTourist:
                    commerical_tou_trade_income += (amount * taxRate/100f);
                    if (commerical_tou_trade_income > 1)
                    {
                        amount = (int)commerical_tou_trade_income;
                        commerical_tou_trade_income = commerical_tou_trade_income - (int)commerical_tou_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_tou_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialEco:
                    commerical_eco_trade_income += (amount * taxRate/100f);
                    if (commerical_eco_trade_income > 1)
                    {
                        amount = (int)commerical_eco_trade_income;
                        commerical_eco_trade_income = commerical_eco_trade_income - (int)commerical_eco_trade_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_eco_tradeincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                default:
                    amount = 0;
                    DebugLog.LogToFileOnly("find unknown  EXAddPrivateTradeIncome building" + " building servise is" + service + " building subservise is" + subService + " buildlevelandtax is" + level + " " + taxRate);
                    break;
            }
            return amount;
        }

        public int EXAddPrivateLandIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            switch (subService)
            {
                case ItemClass.SubService.IndustrialFarming:
                    industy_farm_income += (amount * taxRate/100f);
                    if(industy_farm_income > 1)
                    {
                        amount = (int)industy_farm_income;
                        industy_farm_income = industy_farm_income - (int)industy_farm_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_farmer_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialForestry:
                    industy_forest_income += (amount * taxRate/100f);
                    if (industy_forest_income > 1)
                    {
                        amount = (int)industy_forest_income;
                        industy_forest_income = industy_forest_income - (int)industy_forest_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_foresty_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialOil:
                    industy_oil_income += (amount * taxRate/100f);
                    if (industy_oil_income > 1)
                    {
                        amount = (int)industy_oil_income;
                        industy_oil_income = industy_oil_income - (int)industy_oil_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_oil_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialOre:
                    industy_ore_income += (amount * taxRate/100f);
                    if (industy_ore_income > 1)
                    {
                        amount = (int)industy_ore_income;
                        industy_ore_income = industy_ore_income - (int)industy_ore_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    indu_ore_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.IndustrialGeneric:
                    if (level == ItemClass.Level.Level1)
                    {
                        industy_gen_level1_income += (amount * taxRate/100f);
                        if (industy_gen_level1_income > 1)
                        {
                            amount = (int)industy_gen_level1_income;
                            industy_gen_level1_income = industy_gen_level1_income - (int)industy_gen_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        industy_gen_level2_income += (amount * taxRate/100f);
                        if (industy_gen_level2_income > 1)
                        {
                            amount = (int)industy_gen_level2_income;
                            industy_gen_level2_income = industy_gen_level2_income - (int)industy_gen_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        industy_gen_level3_income += (amount * taxRate/100f);
                        if (industy_gen_level3_income > 1)
                        {
                            amount = (int)industy_gen_level3_income;
                            industy_gen_level3_income = industy_gen_level3_income - (int)industy_gen_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    indu_gen_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialHigh:
                    if (level == ItemClass.Level.Level1)
                    {
                        commerical_high_level1_income += (amount * taxRate/100f);
                        if (commerical_high_level1_income > 1)
                        {
                            amount = (int)commerical_high_level1_income;
                            commerical_high_level1_income = commerical_high_level1_income - (int)commerical_high_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        commerical_high_level2_income += (amount * taxRate/100f);
                        if (commerical_high_level2_income > 1)
                        {
                            amount = (int)commerical_high_level2_income;
                            commerical_high_level2_income = commerical_high_level2_income - (int)commerical_high_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        commerical_high_level3_income += (amount * taxRate/100f);
                        if (commerical_high_level3_income > 1)
                        {
                            amount = (int)commerical_high_level3_income;
                            commerical_high_level3_income = commerical_high_level3_income - (int)commerical_high_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    comm_high_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialLow:
                    if (level == ItemClass.Level.Level1)
                    {
                        commerical_low_level1_income += (amount * taxRate/100f);
                        if (commerical_low_level1_income > 1)
                        {
                            amount = (int)commerical_low_level1_income;
                            commerical_low_level1_income = commerical_low_level1_income - (int)commerical_low_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        commerical_low_level2_income += (amount * taxRate/100f);
                        if (commerical_low_level2_income > 1)
                        {
                            amount = (int)commerical_low_level2_income;
                            commerical_low_level2_income = commerical_low_level2_income - (int)commerical_low_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        commerical_low_level3_income += (amount * taxRate/100f);
                        if (commerical_low_level3_income > 1)
                        {
                            amount = (int)commerical_low_level3_income;
                            commerical_low_level3_income = commerical_low_level3_income - (int)commerical_low_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    comm_low_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialLeisure:
                    commerical_lei_income += (amount * taxRate/100f);
                    if (commerical_lei_income > 1)
                    {
                        amount = (int)commerical_lei_income;
                        commerical_lei_income = commerical_lei_income - (int)commerical_lei_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_lei_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialTourist:
                    commerical_tou_income += (amount * taxRate/100f);
                    if (commerical_tou_income > 1)
                    {
                        amount = (int)commerical_tou_income;
                        commerical_tou_income = commerical_tou_income - (int)commerical_tou_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_tou_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.CommercialEco:
                    commerical_eco_income += (amount * taxRate/100f);
                    if (commerical_eco_income > 1)
                    {
                        amount = (int)commerical_eco_income;
                        commerical_eco_income = commerical_eco_income - (int)commerical_eco_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    comm_eco_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.ResidentialHigh:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_high_level1_income += (amount * taxRate/100f);
                        if (resident_high_level1_income > 1)
                        {
                            amount = (int)resident_high_level1_income;
                            resident_high_level1_income = resident_high_level1_income - (int)resident_high_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_high_level2_income += (amount * taxRate/100f);
                        if (resident_high_level2_income > 1)
                        {
                            amount = (int)resident_high_level2_income;
                            resident_high_level2_income = resident_high_level2_income - (int)resident_high_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_high_level3_income += (amount * taxRate/100f);
                        if (resident_high_level3_income > 1)
                        {
                            amount = (int)resident_high_level3_income;
                            resident_high_level3_income = resident_high_level3_income - (int)resident_high_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_high_level4_income += (amount * taxRate/100f);
                        if (resident_high_level4_income > 1)
                        {
                            amount = (int)resident_high_level4_income;
                            resident_high_level4_income = resident_high_level4_income - (int)resident_high_level4_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_high_level5_income += (amount * taxRate/100f);
                        if (resident_high_level5_income > 1)
                        {
                            amount = (int)resident_high_level5_income;
                            resident_high_level5_income = resident_high_level5_income - (int)resident_high_level5_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    resident_high_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.ResidentialLow:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_low_level1_income += (amount * taxRate/100f);
                        if (resident_low_level1_income > 1)
                        {
                            amount = (int)resident_low_level1_income;
                            resident_low_level1_income = resident_low_level1_income - (int)resident_low_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_low_level2_income += (amount * taxRate/100f);
                        if (resident_low_level2_income > 1)
                        {
                            amount = (int)resident_low_level2_income;
                            resident_low_level2_income = resident_low_level2_income - (int)resident_low_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_low_level3_income += (amount * taxRate/100f);
                        if (resident_low_level3_income > 1)
                        {
                            amount = (int)resident_low_level3_income;
                            resident_low_level3_income = resident_low_level3_income - (int)resident_low_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_low_level4_income += (amount * taxRate/100f);
                        if (resident_low_level4_income > 1)
                        {
                            amount = (int)resident_low_level4_income;
                            resident_low_level4_income = resident_low_level4_income - (int)resident_low_level4_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_low_level5_income += (amount * taxRate/100f);
                        if (resident_low_level5_income > 1)
                        {
                            amount = (int)resident_low_level5_income;
                            resident_low_level5_income = resident_low_level5_income - (int)resident_low_level5_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    resident_low_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.ResidentialHighEco:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_high_eco_level1_income += (amount * taxRate/100f);
                        if (resident_high_eco_level1_income > 1)
                        {
                            amount = (int)resident_high_eco_level1_income;
                            resident_high_eco_level1_income = resident_high_eco_level1_income - (int)resident_high_eco_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_high_eco_level2_income += (amount * taxRate/100f);
                        if (resident_high_eco_level2_income > 1)
                        {
                            amount = (int)resident_high_eco_level2_income;
                            resident_high_eco_level2_income = resident_high_eco_level2_income - (int)resident_high_eco_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_high_eco_level3_income += (amount * taxRate/100f);
                        if (resident_high_eco_level3_income > 1)
                        {
                            amount = (int)resident_high_eco_level3_income;
                            resident_high_eco_level3_income = resident_high_eco_level3_income - (int)resident_high_eco_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_high_eco_level4_income += (amount * taxRate/100f);
                        if (resident_high_eco_level4_income > 1)
                        {
                            amount = (int)resident_high_eco_level4_income;
                            resident_high_eco_level4_income = resident_high_eco_level4_income - (int)resident_high_eco_level4_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_high_eco_level5_income += (amount * taxRate/100f);
                        if (resident_high_eco_level5_income > 1)
                        {
                            amount = (int)resident_high_eco_level5_income;
                            resident_high_eco_level5_income = resident_high_eco_level5_income - (int)resident_high_eco_level5_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    resident_high_eco_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.ResidentialLowEco:
                    if (level == ItemClass.Level.Level1)
                    {
                        resident_low_eco_level1_income += (amount * taxRate/100f);
                        if (resident_low_eco_level1_income > 1)
                        {
                            amount = (int)resident_low_eco_level1_income;
                            resident_low_eco_level1_income = resident_low_eco_level1_income - (int)resident_low_eco_level1_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level2)
                    {
                        resident_low_eco_level2_income += (amount * taxRate/100f);
                        if (resident_low_eco_level2_income > 1)
                        {
                            amount = (int)resident_low_eco_level2_income;
                            resident_low_eco_level2_income = resident_low_eco_level2_income - (int)resident_low_eco_level2_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level3)
                    {
                        resident_low_eco_level3_income += (amount * taxRate/100f);
                        if (resident_low_eco_level3_income > 1)
                        {
                            amount = (int)resident_low_eco_level3_income;
                            resident_low_eco_level3_income = resident_low_eco_level3_income - (int)resident_low_eco_level3_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level4)
                    {
                        resident_low_eco_level4_income += (amount * taxRate/100f);
                        if (resident_low_eco_level4_income > 1)
                        {
                            amount = (int)resident_low_eco_level4_income;
                            resident_low_eco_level4_income = resident_low_eco_level4_income - (int)resident_low_eco_level4_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    else if (level == ItemClass.Level.Level5)
                    {
                        resident_low_eco_level5_income += (amount * taxRate/100f);
                        if (resident_low_eco_level5_income > 1)
                        {
                            amount = (int)resident_low_eco_level5_income;
                            resident_low_eco_level5_income = resident_low_eco_level5_income - (int)resident_low_eco_level5_income;
                        }
                        else
                        {
                            amount = 0;
                        }
                    }
                    resident_low_eco_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.OfficeGeneric:
                        if (level == ItemClass.Level.Level1)
                        {
                            office_gen_level1_income += (amount * taxRate/100f);
                            if (office_gen_level1_income > 1)
                            {
                                amount = (int)office_gen_level1_income;
                                office_gen_level1_income = office_gen_level1_income - (int)office_gen_level1_income;
                            }
                            else
                            {
                                amount = 0;
                            }
                        }
                        else if (level == ItemClass.Level.Level2)
                        {
                            office_gen_level2_income += (amount * taxRate/100f);
                            if (office_gen_level2_income > 1)
                            {
                                amount = (int)office_gen_level2_income;
                                office_gen_level2_income = office_gen_level2_income - (int)office_gen_level2_income;
                            }
                            else
                            {
                                amount = 0;
                            }
                        }
                        else if (level == ItemClass.Level.Level3)
                        {
                            office_gen_level3_income += (amount * taxRate/100f);
                            if (office_gen_level1_income > 1)
                            {
                                amount = (int)office_gen_level3_income;
                                office_gen_level3_income = office_gen_level3_income - (int)office_gen_level3_income;
                            }
                            else
                            {
                                amount = 0;
                            }
                        }
                    office_gen_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                case ItemClass.SubService.OfficeHightech:
                    office_high_tech_income+= (amount * taxRate/100f);
                    if (office_high_tech_income > 1)
                    {
                        amount = (int)office_high_tech_income;
                        office_high_tech_income = office_high_tech_income - (int)office_high_tech_income;
                    }
                    else
                    {
                        amount = 0;
                    }
                    office_high_tech_landincome_forui[MainDataStore.update_money_count] += amount;
                    break;
                default:
                    amount = 0;
                    DebugLog.LogToFileOnly("find unknown  EXAddPrivateLandIncome building" + " building servise is" + service + " building subservise is" + subService + " buildlevelandtax is" + level + " " + taxRate);
                    break;
            }
            return amount;
        }

        public int AddPrivateIncome(int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level, int taxRate)
        {
            if (!_init)
            {
                _init = true;
                Init();
            }
            if (amount < 0)
            {
                DebugLog.LogToFileOnly("income < 0 error: class =" + service.ToString() + subService.ToString() + level.ToString());
            }
            if (taxRate == 115)
            {
                //115 means playerbuilding income
                taxRate = 100;
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
                amount = EXAddGovermentIncome(amount, service, subService, level, taxRate);
                service = ItemClass.Service.Industrial;
                subService = ItemClass.SubService.IndustrialGeneric;
                level = ItemClass.Level.Level3;
                int num = ClassIndex(service, subService, level);
                if (num != -1)
                {
                    _income[num * 17 + 16] += amount;
                }
                MainDataStore.cashAmount += amount;
                MainDataStore.cashDelta += amount;
            }
            else if ((taxRate == 113) || (taxRate == 114))
            {
                //113 means tourist tourism income // 114 means resident tourism income
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
                amount = EXAddTourismIncome(amount, service, subService, level, taxRate);
                int num = ClassIndex(service, subService, level);
                if (num != -1)
                {
                    _income[num * 17 + 16] += amount;
                }
                MainDataStore.cashAmount += amount;
                MainDataStore.cashDelta += amount;
            }
            else if (taxRate == 112)
            {
                //112 means personal slary tax income
                taxRate = 100;
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
                amount = EXAddPersonalTaxIncome(amount, service, subService, level, taxRate);
                int num = ClassIndex(service, subService, level);
                if (num != -1)
                {
                    _income[num * 17 + 16] += amount;
                }
                MainDataStore.cashAmount += amount;
                MainDataStore.cashDelta += amount;
            }
            else if (taxRate == 111)
            {
                //111 means trade income
                taxRate = 100;
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
                amount = EXAddPrivateTradeIncome(amount, service, subService, level, taxRate);
                int num = ClassIndex(service, subService, level);
                if (num != -1)
                {
                    _income[num * 17 + 16] += amount;
                }
                MainDataStore.cashAmount += amount;
                MainDataStore.cashDelta += amount;
            }
            else if (taxRate >= 100)
            {
                taxRate = taxRate / 100;
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
                amount = EXAddPrivateLandIncome(amount, service, subService, level, taxRate);
                int num = ClassIndex(service, subService, level);
                if (num != -1)
                {
                    _income[num * 17 + 16] += amount;
                }
                MainDataStore.cashAmount += amount;
                MainDataStore.cashDelta += amount;
            }
            else
            {
                //vanilla old logic
                Singleton<EconomyManager>.instance.m_EconomyWrapper.OnAddResource(EconomyManager.Resource.PrivateIncome, ref amount, service, subService, level);
            }
            return amount;
        }

        public int AddResource(EconomyManager.Resource resource, int amount, ItemClass itemClass)
        {
            // NON-STOCK CODE START
            if (resource == EconomyManager.Resource.TourismIncome)
            {
                if (itemClass.m_service == ItemClass.Service.Beautification)
                {
                    return Singleton<EconomyManager>.instance.AddResource(resource, 0, ItemClass.Service.Commercial, ItemClass.SubService.CommercialTourist, itemClass.m_level, DistrictPolicies.Taxation.None);
                }
                else
                {
                    return Singleton<EconomyManager>.instance.AddResource(resource, 0, itemClass.m_service, itemClass.m_subService, itemClass.m_level, DistrictPolicies.Taxation.None);
                }
            }
            else if (resource == EconomyManager.Resource.ResourcePrice)
            {
                    playerIndustryIncomeForUI[MainDataStore.update_money_count] += amount;
            }
            else if (resource == EconomyManager.Resource.PublicIncome && itemClass.m_service == ItemClass.Service.Beautification)
            {
                if (amount > 0)
                {
                    citizen_income_forui[MainDataStore.update_money_count] += amount;
                }
                else
                {
                    //We use negetive amount to identify tourist income
                    amount = -amount;
                    tourist_income_forui[MainDataStore.update_money_count] += amount;
                }
            }
            /// NON-STOCK CODE END ///
            return Singleton<EconomyManager>.instance.AddResource(resource, amount, itemClass.m_service, itemClass.m_subService, itemClass.m_level, DistrictPolicies.Taxation.None);
        }

        public int AddResource(EconomyManager.Resource resource, int amount, ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level)
        {
            // NON-STOCK CODE START
            if (resource == EconomyManager.Resource.PublicIncome)
            {
                if (service == ItemClass.Service.Vehicles)
                {
                    road_income_forui[MainDataStore.update_money_count] += amount;
                }
            }
            else if (resource == EconomyManager.Resource.ResourcePrice)
            {
                playerIndustryIncomeForUI[MainDataStore.update_money_count] += amount;
            }
            /// NON-STOCK CODE END ///
            return Singleton<EconomyManager>.instance.AddResource(resource, amount, service, subService, level, DistrictPolicies.Taxation.None);
        }

        private static int ClassIndex(ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level)
        {
            int privateServiceIndex = ItemClass.GetPrivateServiceIndex(service);
            if (privateServiceIndex != -1)
            {
                return PrivateClassIndex(service, subService, level);
            }
            return PublicClassIndex(service, subService) + 120;
        }
        // EconomyManager
        private static int PrivateClassIndex(ItemClass.Service service, ItemClass.SubService subService, ItemClass.Level level)
        {
            int privateServiceIndex = ItemClass.GetPrivateServiceIndex(service);
            int privateSubServiceIndex = ItemClass.GetPrivateSubServiceIndex(subService);
            if (privateServiceIndex == -1)
            {
                return -1;
            }
            int num;
            if (privateSubServiceIndex != -1)
            {
                num = 8 + privateSubServiceIndex;
            }
            else
            {
                num = privateServiceIndex;
            }
            num *= 5;
            if (level != ItemClass.Level.None)
            {
                num = (int)(num + level);
            }
            return num;
        }

        private static int PublicClassIndex(ItemClass.Service service, ItemClass.SubService subService)
        {
            int publicServiceIndex = ItemClass.GetPublicServiceIndex(service);
            int publicSubServiceIndex = ItemClass.GetPublicSubServiceIndex(subService);
            if (publicServiceIndex == -1)
            {
                return -1;
            }
            int result;
            if (publicSubServiceIndex != -1)
            {
                result = 13 + publicSubServiceIndex;
            }
            else
            {
                result = publicServiceIndex;
            }
            return result;
        }

        public static void Init()
        {
            DebugLog.LogToFileOnly("Init fake transfer manager");
            try
            {
                var inst = Singleton<EconomyManager>.instance;
                var income = typeof(EconomyManager).GetField("m_income", BindingFlags.NonPublic | BindingFlags.Instance);
                cashDelta = typeof(EconomyManager).GetField("m_cashDelta", BindingFlags.NonPublic | BindingFlags.Instance);
                cashAmount = typeof(EconomyManager).GetField("m_cashAmount", BindingFlags.NonPublic | BindingFlags.Instance);
                if (inst == null)
                {
                    DebugLog.LogToFileOnly("No instance of EconomyManager found!");
                    return;
                }
                _income = income.GetValue(inst) as long[];
                if (_income == null)
                {
                    DebugLog.LogToFileOnly("EconomyManager Arrays are null");
                }
            }
            catch (Exception ex)
            {
                DebugLog.LogToFileOnly("EconomyManager Exception: " + ex.Message);
            }
        }
        public static FieldInfo cashAmount;
        public static FieldInfo cashDelta;
        private static long[] _income;
        public static bool _init;
    }
}
