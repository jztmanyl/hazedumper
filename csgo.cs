using System;

// Offsets timestamp
// Wed,  3 May 2017 14:47:00 +0200

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xAA04;
        public const Int32 m_Collision = 0x318;
        public const Int32 m_CollisionGroup = 0x470;
        public const Int32 m_Local = 0x2FAC;
        public const Int32 m_MoveType = 0x258;
        public const Int32 m_OriginalOwnerXuidHigh = 0x316C;
        public const Int32 m_OriginalOwnerXuidLow = 0x3168;
        public const Int32 m_aimPunchAngle = 0x301C;
        public const Int32 m_aimPunchAngleVel = 0x3028;
        public const Int32 m_bGunGameImmunity = 0x38B0;
        public const Int32 m_bHasDefuser = 0xAA14;
        public const Int32 m_bHasHelmet = 0xA9FC;
        public const Int32 m_bInReload = 0x3245;
        public const Int32 m_bIsDefusing = 0x38A4;
        public const Int32 m_bIsScoped = 0x389C;
        public const Int32 m_bSpotted = 0x939;
        public const Int32 m_bSpottedByMask = 0x97C;
        public const Int32 m_dwBoneMatrix = 0x2698;
        public const Int32 m_fAccuracyPenalty = 0x32C0;
        public const Int32 m_fFlags = 0x100;
        public const Int32 m_flFallbackWear = 0x3178;
        public const Int32 m_flFlashDuration = 0xA308;
        public const Int32 m_flFlashMaxAlpha = 0xA304;
        public const Int32 m_flNextPrimaryAttack = 0x31D8;
        public const Int32 m_hActiveWeapon = 0x2EE8;
        public const Int32 m_hMyWeapons = 0x2DE8;
        public const Int32 m_hObserverTarget = 0x3380;
        public const Int32 m_hOwner = 0x29BC;
        public const Int32 m_hOwnerEntity = 0x148;
        public const Int32 m_iAccountID = 0x2FA8;
        public const Int32 m_iClip1 = 0x3204;
        public const Int32 m_iCompetitiveRanking = 0x1A44;
        public const Int32 m_iCompetitiveWins = 0x1B48;
        public const Int32 m_iCrosshairId = 0xAA70;
        public const Int32 m_iEntityQuality = 0x2F8C;
        public const Int32 m_iFOVStart = 0x31D8;
        public const Int32 m_iGlowIndex = 0xA320;
        public const Int32 m_iHealth = 0xFC;
        public const Int32 m_iItemDefinitionIndex = 0x2F88;
        public const Int32 m_iItemIDHigh = 0x2FA0;
        public const Int32 m_iObserverMode = 0x336C;
        public const Int32 m_iShotsFired = 0xA2C0;
        public const Int32 m_iState = 0x31F8;
        public const Int32 m_iTeamNum = 0xF0;
        public const Int32 m_lifeState = 0x25B;
        public const Int32 m_nFallbackPaintKit = 0x3170;
        public const Int32 m_nFallbackSeed = 0x3174;
        public const Int32 m_nFallbackStatTrak = 0x317C;
        public const Int32 m_nForceBone = 0x267C;
        public const Int32 m_nTickBase = 0x3424;
        public const Int32 m_rgflCoordinateFrame = 0x440;
        public const Int32 m_szCustomName = 0x301C;
        public const Int32 m_szLastPlaceName = 0x35A8;
        public const Int32 m_vecOrigin = 0x134;
        public const Int32 m_vecVelocity = 0x110;
        public const Int32 m_vecViewOffset = 0x104;
        public const Int32 m_viewPunchAngle = 0x3010;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x5CC574;
        public const Int32 dwClientState_GetLocalPlayer = 0x178;
        public const Int32 dwClientState_Map = 0x284;
        public const Int32 dwClientState_MapDirectory = 0x180;
        public const Int32 dwClientState_MaxPlayer = 0x308;
        public const Int32 dwClientState_PlayerInfo = 0x523C;
        public const Int32 dwClientState_State = 0x100;
        public const Int32 dwClientState_ViewAngles = 0x4D0C;
        public const Int32 dwEntityList = 0x4AD5C24;
        public const Int32 dwForceBackward = 0x2F15C7C;
        public const Int32 dwForceForward = 0x2F15C58;
        public const Int32 dwForceLeft = 0x2F15C70;
        public const Int32 dwForceRight = 0x2F15BF8;
        public const Int32 dwGameDir = 0x66B460;
        public const Int32 dwGameRulesProxy = 0x2F13E94;
        public const Int32 dwGetAllClasses = 0x2F13F48;
        public const Int32 dwGlobalVars = 0xAA63A0;
        public const Int32 dwGlowObjectManager = 0x4FF077C;
        public const Int32 dwInput = 0x4F20770;
        public const Int32 dwInterfaceLinkList = 0x72EEC4;
        public const Int32 dwLocalPlayer = 0xAB26E8;
        public const Int32 dwMouseEnable = 0xAB7F30;
        public const Int32 dwMouseEnablePtr = 0xAB7F00;
        public const Int32 dwPlayerResource = 0x2F13E4C;
        public const Int32 dwRadarBase = 0x4F0A99C;
        public const Int32 dwSensitivity = 0xAB7ED4;
        public const Int32 dwSensitivityPtr = 0xAB7EA8;
        public const Int32 dwViewMatrix = 0x4AC77C4;
        public const Int32 dwWeaponTable = 0x4F1CD9C;
        public const Int32 dwWeaponTableIndex = 0x3270;
        public const Int32 dwYawPtr = 0xAB7DA0;
        public const Int32 dwZoomSensitivityRatioPtr = 0xABCBF0;
        public const Int32 dwbSendPackets = 0xE5B5A;
        public const Int32 dwppDirect3DDevice9 = 0x99EA0;
        public const Int32 dwSetClanTag = 0x9E260;
        public const Int32 m_pStudioHdr = 0x293C;
    }
} // namespace hazedumper
