﻿using System;

public enum Opcodes
{
    ProtocolHandshakeVersion = 0x01B7,

    ProtocolPingPong = 0x0002,
    ProtocolHandshakeCompression = 0x0019,

    ProtocolHandshakeClientKey = 0x1153F70,
    ProtocolHandshakeServerKey = 0x1153F6A,

    ProtocolHandshakeAuthenticationRequest = 0x14BA450,
    ProtocolHandshakeAuthenticationResponse = 0x142DDFC,

    LobbyWorldListRequest = 0xEC2ED0,
    LobbyWorldListResponse = 0xEC2ED0,
    LobbyWorldEntry = 0xF08420,

    LobbyWorldSelectRequest = 0x1226EF0,
    LobbyWorldSelectResponse = 0xD8DC60,

    LobbyCharacterListRequest = 0x01B3,
    LobbyCharacterListResponse = 0x01B4,

    LobbyCharacterDeleteRequest = 0x01E8,
    LobbyCharacterDeleteResponse = 0x01E9,

    LobbyCharacterEntry = 0x01D7,
    LobbyCharacterInfoBase = 0x01DD,
    CharacterInfoDesc = 0x0DBF,
    CharacterInfoCache = 0x0E10,
    CharacterCustom = 0x00DE,

    LobbyCharacterCreationCacheRequest = 0x01C2,
    LobbyCharacterCreationCacheResponse = 0x01C3,

    LobbyCharacterCreateRequest = 0x01D5,
    LobbyCharacterCreateResponse = 0x01D6,

    LobbyCharacterCreation_NameRequest = 0x01EF,
    LobbyCharacterCreation_NameResponse = 0x01F0,

    CacheUpdate = 0x0025,
    TemplateCreationData = 0x027E,
    TemplateCreationUnknown1Data = 0x0ECD,
    TemplateCreationSubData = 0x0274,
    TemplateCreationSubUnknown1Data = 0x1C97,
    TemplateCreationSubUnknown2Data = 0x1C9D,
    TemplateCreationSubUnknown3Data = 0x1C9C,
    TemplateCreationSubUnknown4Data = 0x1CD2,
    
    WorldText_Info = 0x1E17,

    LobbyCharacterSelectRequest = 0x01B1,
    LobbyCharacterSelectResponse = 0x01B2,

    IPCWorldRegisterRequest = 0x149157C,
    IPCWorldRegisterResponse = 0x010001,
    IPCWorldPopulationUpdate = 0x010002,

    WorldAuthenticationRequest = 0x03E8,
    WorldAuthenticationResponse = 0x03E9,
    WorldCacheUpdated = 0x03EA,

    // Friend List
    WorldGUIDUpdateUnk = 0x02B2,

    WorldZoneInfo = 0x0080,
    WorldMapInfo = 0x1E17,
    WorldStartingPosition = 0x03EF,
    WorldEntityUpdate = 0x03EC,
    WorldStartingPositionExtra = 0x03ED,
    WorldPositionExtra = 0x025B,

    WorldMapLoaded = 0x0DAF,
    WorldCanConnect = 0x1E99,
    WorldTemplateUpdate = 0x0271,
    WorldChannelJoinned = 0x10CE,

    WorldServerMOTD = 0x010E9,

    WorldServerPositionUpdate = 0x0007,
    WorldPorticulumTeleport = 0x0E55,
    WorldPorticulumConfirm = 0x11CE,
    WorldTeleport = 0x0F04,
    WorldChatMessage = 0x010CC
}