﻿using ColossalFramework.UI;
using UnityEngine;
using ColossalFramework;
using RealCity.CustomAI;
using RealCity.Util;

namespace RealCity.UI
{
    public class PlayerBuildingUI : UIPanel
    {
        public static readonly string cacheName = "PlayerBuildingUI";
        private static readonly float SPACING = 15f;
        private static readonly float SPACING22 = 22f;
        public CityServiceWorldInfoPanel baseBuildingWindow;
        public static bool refeshOnce = false;
        private UILabel maintainFeeTips;
        private UILabel workerStatus;

        public override void Update()
        {
            RefreshDisplayData();
            base.Update();
        }

        public override void Awake()
        {
            base.Awake();
            DoOnStartup();
        }

        public override void Start()
        {
            base.Start();
            canFocus = true;
            isInteractive = true;
            isVisible = true;
            opacity = 1f;
            cachedName = cacheName;
            RefreshDisplayData();
            Hide();
        }

        private void DoOnStartup()
        {
            ShowOnGui();
            Hide();          
        }

        private void ShowOnGui()
        {
            maintainFeeTips = AddUIComponent<UILabel>();
            maintainFeeTips.text = Localization.Get("MAINTAIN_FEE_TIPS");
            maintainFeeTips.relativePosition = new Vector3(SPACING, 10f);
            maintainFeeTips.autoSize = true;

            workerStatus = AddUIComponent<UILabel>();
            workerStatus.text = Localization.Get("LOCAL_WORKERS_DIV_TOTAL_WORKERS");
            workerStatus.relativePosition = new Vector3(SPACING, maintainFeeTips.relativePosition.y + SPACING22);
            workerStatus.autoSize = true;
        }

        private void RefreshDisplayData()
        {
            uint currentFrameIndex = Singleton<SimulationManager>.instance.m_currentFrameIndex;
            uint num2 = currentFrameIndex & 255u;
     
            if (refeshOnce || (MainDataStore.last_buildingid != WorldInfoPanel.GetCurrentInstanceID().Building))
            {
                if (isVisible)
                {
                    MainDataStore.last_buildingid = WorldInfoPanel.GetCurrentInstanceID().Building;
                    Building buildingData = Singleton<BuildingManager>.instance.m_buildings.m_buffer[MainDataStore.last_buildingid];
                    int aliveWorkCount = 0;
                    int totalWorkCount = 0;
                    Citizen.BehaviourData behaviour = default(Citizen.BehaviourData);
                    BuildingUI.GetWorkBehaviour(MainDataStore.last_buildingid, ref buildingData, ref behaviour, ref aliveWorkCount, ref totalWorkCount);
                    int allWorkCount = RealCityResidentAI.TotalWorkCount(MainDataStore.last_buildingid, buildingData, true, false);
                    maintainFeeTips.text = Localization.Get("MAINTAIN_FEE_TIPS");
                    workerStatus.text = Localization.Get("LOCAL_WORKERS_DIV_TOTAL_WORKERS") + totalWorkCount.ToString() + "/" + allWorkCount.ToString();
                    refeshOnce = false;
                }
                else
                {
                    Hide();
                }
            }

        }

    }
}
