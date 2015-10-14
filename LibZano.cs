// 88888888888     db      888b     88  ,ad8888ba,
//         ,88    d88b     8888b    88 d8"'    `"8b
//       ,88"    d8'`8b    88 `8b   88d8'        `8b
//    ,88"      d8'  `8b   88  `8b  8888          88
//  ,88"       d8'    `8b  88   `8b 88Y8,        ,8P
// 88"        d8'      `8b 88    `8888 Y8a.    .a8P
// 8888888888d8'  88888888b88     `888  `"Y8888Y"'
//
// Copyright 2015 Torquing Robotics Ltd.

using System;
using System.Runtime.InteropServices;
using System.Security;
namespace LibZano
{
	public class Symbols
	{
		public const uint kAccountLogin                            = (0x41355389u);
		public const uint kAccountLoginResponse                    = (0x387F1302u);
		public const uint kAccountWebLogin                         = (0x4152CA50u);
		public const uint kAccountWebLoginResponse                 = (0x88B61F75u);
		public const uint kActiveFilter                            = (0x618815B6u);
		public const uint kAltitude                                = (0xF8C175A3u);
		public const uint kAltitudeDeltaThreshold                  = (0x817A74EFu);
		public const uint kAltitudeTarget                          = (0x5753DAE0u);
		public const uint kAmbient                                 = (0x19BE3506u);
		public const uint kAmbientFilter                           = (0xB311E4A1u);
		public const uint kAngle                                   = (0x70165925u);
		public const uint kBack                                    = (0x2EE8E70Fu);
		public const uint kBackAmbient                             = (0x8A5C0D4Du);
		public const uint kBackCt                                  = (0xA717F04Fu);
		public const uint kBackResult                              = (0x4FFA583Eu);
		public const uint kBrightness                              = (0xC09CC82Du);
		public const uint kCameraAgcEvlevelGet                     = (0xAC2E038Fu);
		public const uint kCameraAgcEvlevelSet                     = (0xB217DBBAu);
		public const uint kCameraAgcExposureControlGet             = (0x1D2C0234u);
		public const uint kCameraAgcExposureControlSet             = (0x2314FA30u);
		public const uint kCameraAgcExposureGet                    = (0x1BE17688u);
		public const uint kCameraAgcExposureSet                    = (0x21CA06BFu);
		public const uint kCameraAgcExposureWeightGet              = (0x603877B5u);
		public const uint kCameraAgcExposureWeightSet              = (0x6620B7B9u);
		public const uint kCameraBandingfilterGet                  = (0x1FE35B27u);
		public const uint kCameraBandingfilterSet                  = (0x25CBDB1Bu);
		public const uint kCameraBrightnessGet                     = (0xE09B8B39u);
		public const uint kCameraBrightnessSet                     = (0xE684C32Au);
		public const uint kCameraContrastGet                       = (0x2BA74734u);
		public const uint kCameraContrastSet                       = (0x3190170Fu);
		public const uint kCameraFpsGet                            = (0x33C3866Bu);
		public const uint kCameraFpsSet                            = (0x39AC5618u);
		public const uint kCameraHueGet                            = (0x980ADEDDu);
		public const uint kCameraHueSet                            = (0x9DF39D10u);
		public const uint kCameraImageprocessingDenoiseGet         = (0x12D1B269u);
		public const uint kCameraImageprocessingDenoiseSet         = (0x18BA427Eu);
		public const uint kCameraImageprocessingLencGet            = (0xFFCBA7D4u);
		public const uint kCameraImageprocessingLencSet            = (0x05B4179Fu);
		public const uint kCameraImageprocessingPixelcorrectionGet = (0xA7A7D244u);
		public const uint kCameraImageprocessingPixelcorrectionSet = (0xAD90827Fu);
		public const uint kCameraImageprocessingSharpnessGet       = (0x9A987BD8u);
		public const uint kCameraImageprocessingSharpnessSet       = (0xA0813BCDu);
		public const uint kCameraMirrorflipGet                     = (0xC6260F7Bu);
		public const uint kCameraMirrorflipSet                     = (0xCC0F4F66u);
		public const uint kCameraModeGet                           = (0x0239FBEDu);
		public const uint kCameraModeSet                           = (0x0822BBC2u);
		public const uint kCameraPhotoGet                          = (0xEE4865F9u);
		public const uint kCameraResolutionGet                     = (0x74C9EDB4u);
		public const uint kCameraResolutionSet                     = (0x7AB2293Bu);
		public const uint kCameraSaturationGet                     = (0xD3DFB23Cu);
		public const uint kCameraSaturationSet                     = (0xD9C8C227u);
		public const uint kCameraSpecialeffectsGet                 = (0x7293BCE9u);
		public const uint kCameraSpecialeffectsSet                 = (0x787CF0FAu);
		public const uint kCameraStabiliseGet                      = (0xE5A87EFDu);
		public const uint kCameraStabiliseSet                      = (0xEB91BEF0u);
		public const uint kCameraStreamStart                       = (0x131F1BA2u);
		public const uint kCameraStreamStop                        = (0xADBBF55Cu);
		public const uint kCameraTiltGet                           = (0x1EF0C4FEu);
		public const uint kCameraTiltSet                           = (0x24D9B0C3u);
		public const uint kCameraUvadjustGet                       = (0x558EE6EFu);
		public const uint kCameraUvadjustSet                       = (0x5B77361Au);
		public const uint kCameraVideoKeyframeGet                  = (0xA198AE0Au);
		public const uint kCameraVideoResolutionGet                = (0x0A84CD74u);
		public const uint kCameraVideoResolutionSet                = (0x106D9191u);
		public const uint kCameraWindowGet                         = (0xD9935492u);
		public const uint kCameraWindowSet                         = (0xDF7C9871u);
		public const uint kCannotConnect                           = (0x3E480A2Fu);
		public const uint kCharge                                  = (0x3F431A37u);
		public const uint kColour                                  = (0x191892B4u);
		public const uint kCompletedCount                          = (0x718E3ACAu);
		public const uint kConfigAccelOffsetGet                    = (0xEC6626EBu);
		public const uint kConfigAccelOffsetSet                    = (0xF24F76D6u);
		public const uint kConfigAltitudePidGet                    = (0xE704ECF7u);
		public const uint kConfigAltitudePidSet                    = (0xECEC2913u);
		public const uint kConfigCameraSet                         = (0xAB575B72u);
		public const uint kConfigCompassEnableGet                  = (0xE1F7E064u);
		public const uint kConfigDegreeratioGet                    = (0xB19C34C7u);
		public const uint kConfigDegreeratioSet                    = (0xB78588E2u);
		public const uint kConfigGpsEnableGet                      = (0x92A412DFu);
		public const uint kConfigGpsEnableSet                      = (0x988DA20Au);
		public const uint kConfigGpsPidGet                         = (0xD28FD6CCu);
		public const uint kConfigGpsPidSet                         = (0xD8776638u);
		public const uint kConfigGyroOffsetGet                     = (0x89F1B37Fu);
		public const uint kConfigGyroOffsetSet                     = (0x8FD97B43u);
		public const uint kConfigInertialPidGet                    = (0x53841307u);
		public const uint kConfigInertialPidSet                    = (0x596CA3E3u);
		public const uint kConfigIntegrationGet                    = (0xF6002CB0u);
		public const uint kConfigIntegrationSet                    = (0xFBE96F55u);
		public const uint kConfigIrFilterGet                       = (0x9B455C9Cu);
		public const uint kConfigIrFilterSet                       = (0xA12E20CBu);
		public const uint kConfigLostlinkLimitGet                  = (0xAACF25F0u);
		public const uint kConfigLostlinkLimitSet                  = (0xB0B8F9F3u);
		public const uint kConfigMagOffsetGet                      = (0xC4CB5AC9u);
		public const uint kConfigMagOffsetSet                      = (0xCAB492BAu);
		public const uint kConfigMagRangeGet                       = (0x1A183E46u);
		public const uint kConfigMagTrueGet                        = (0x9A829A1Fu);
		public const uint kConfigMagTrueSet                        = (0xA06A1AC3u);
		public const uint kConfigMinsatGet                         = (0x16A407ECu);
		public const uint kConfigMinsatSet                         = (0x1C8CD7D8u);
		public const uint kConfigNoactivityLimitGet                = (0x962C2F9Du);
		public const uint kConfigNoactivityLimitSet                = (0x9C15EFA8u);
		public const uint kConfigObstacleavoidanceEnableGet        = (0x04825472u);
		public const uint kConfigObstacleavoidanceEnableSet        = (0x0A6B0097u);
		public const uint kConfigObstaclePidGet                    = (0x307A499Au);
		public const uint kConfigObstaclePidSet                    = (0x3663058Fu);
		public const uint kConfigOnegGet                           = (0xB986C6B3u);
		public const uint kConfigOnegSet                           = (0xBF6F862Eu);
		public const uint kConfigPitchrollPidGet                   = (0x0EFB50ADu);
		public const uint kConfigPitchrollPidSet                   = (0x14E40C86u);
		public const uint kConfigPitchrollyawTrimGet               = (0xA6F6C3CCu);
		public const uint kConfigPitchrollyawTrimSet               = (0xACDFB399u);
		public const uint kConfigSave                              = (0x4E8BBFC2u);
		public const uint kConfigSonarSet                          = (0xCED964B2u);
		public const uint kConfigYawPidGet                         = (0xF19FFC37u);
		public const uint kConfigYawPidSet                         = (0xF7873033u);
		public const uint kConnected                               = (0x85D5E05Cu);
		public const uint kConstantsGet                            = (0x1DABF61Cu);
		public const uint kContrast                                = (0xC0AB7689u);
		public const uint kCount                                   = (0x2D5CBCD3u);
		public const uint kCrosstalk                               = (0x78A041CCu);
		public const uint kD                                       = (0x00000044u);
		public const uint kDeltaAltitude                           = (0x1951C50Bu);
		public const uint kDeltaHeading                            = (0x5085B60Fu);
		public const uint kDepth                                   = (0x9D94E097u);
		public const uint kDerivative                              = (0x17F67C91u);
		public const uint kDerivativeClamp                         = (0x2BF875ACu);
		public const uint kDistance                                = (0xBCFC2309u);
		public const uint kDistanceX                               = (0x22207F83u);
		public const uint kDistanceY                               = (0x22207F84u);
		public const uint kDistanceZ                               = (0x22207F85u);
		public const uint kFilter                                  = (0xC6797881u);
		public const uint kFilterAway                              = (0xF42DE0EBu);
		public const uint kFilterCloser                            = (0xB2635791u);
		public const uint kFirmwareDownloadEnd                     = (0x13A84F30u);
		public const uint kFirmwareDownloadError                   = (0x1982D1E7u);
		public const uint kFirmwareDownloadFailed                  = (0xFEC925C9u);
		public const uint kFirmwareFlashEnd                        = (0x0D82DE04u);
		public const uint kFirmwareFlashStart                      = (0x6253175Eu);
		public const uint kFirmwareFlashState                      = (0x62551729u);
		public const uint kFlag                                    = (0xEE6C5880u);
		public const uint kFlags                                   = (0x63AD672Au);
		public const uint kFlightAltitudeGet                       = (0x4423690Bu);
		public const uint kFlightAltitudeSet                       = (0x4A0BAD3Fu);
		public const uint kFlightAutoPitchSet                      = (0x321C720Fu);
		public const uint kFlightAutoRollSet                       = (0xDAB1D5E3u);
		public const uint kFlightControlInvertGet                  = (0xBC5E2573u);
		public const uint kFlightControlInvertSet                  = (0xC247917Eu);
		public const uint kFlightHeadingGet                        = (0x071DF651u);
		public const uint kFlightHeadingSet                        = (0x0D06A65Eu);
		public const uint kFlightIsoutdoorGet                      = (0xEE00D55Cu);
		public const uint kFlightIsoutdoorSet                      = (0xF3E80680u);
		public const uint kFlightLand                              = (0xF641AF08u);
		public const uint kFlightLaunch                            = (0x281685C7u);
		public const uint kFlightModeGet                           = (0xEFA17788u);
		public const uint kFlightModeSet                           = (0xF58AA7BFu);
		public const uint kFlightPitchGet                          = (0x769CB836u);
		public const uint kFlightPitchSet                          = (0x7C85F433u);
		public const uint kFlightQuicksnap                         = (0x143C7A25u);
		public const uint kFlightRelativeAltitudeSet               = (0xF2257D7Fu);
		public const uint kFlightRelativeHeadingSet                = (0xA2423BF0u);
		public const uint kFlightRollGet                           = (0xABD31830u);
		public const uint kFlightRollSet                           = (0xB1BCDC53u);
		public const uint kFlightRth                               = (0x22E85D60u);
		public const uint kFlightThrustGet                         = (0xE5D6B448u);
		public const uint kFlightThrustSet                         = (0xEBBFE015u);
		public const uint kFragmentSize                            = (0xEC5A98ABu);
		public const uint kFrame                                   = (0x7ADB90B6u);
		public const uint kFront                                   = (0x81C14208u);
		public const uint kFrontAmbient                            = (0xDD06E5A9u);
		public const uint kFrontCt                                 = (0x1A4D9A77u);
		public const uint kFrontResult                             = (0xB2B4AC12u);
		public const uint kHDOP                                    = (0x37B5D008u);
		public const uint kHeading                                 = (0x18F16B73u);
		public const uint kHeadingAdjust                           = (0x51DE2E6Fu);
		public const uint kHue                                     = (0x23E95A91u);
		public const uint kI                                       = (0x00000049u);
		public const uint kid                                      = (0x00691A52u);
		public const uint kIndex                                   = (0x8DF77CE5u);
		public const uint kIntegral                                = (0x4F9DFCF1u);
		public const uint kIntegralClamp                           = (0x0F48F3C7u);
		public const uint kLatitude                                = (0xC6AB37A7u);
		public const uint kLatitudeDirection                       = (0x185F302Cu);
		public const uint kLeft                                    = (0x0228320Fu);
		public const uint kLeftAmbient                             = (0x869C964Du);
		public const uint kLeftCt                                  = (0x2487B91Fu);
		public const uint kLeftResult                              = (0xFA7CE478u);
		public const uint kLength                                  = (0x9288F48Eu);
		public const uint kLightsLandingGet                        = (0x4DB9F577u);
		public const uint kLightsLandingSet                        = (0x53A22178u);
		public const uint kLongitude                               = (0x7DA8AF67u);
		public const uint kLongitudeDirection                      = (0x6E321342u);
		public const uint kMediaGet                                = (0x44D0AF3Cu);
		public const uint kMediaRecv                               = (0xDB10D880u);
		public const uint kMessage                                 = (0xC45543D2u);
		public const uint kMessagesGet                             = (0x54920B86u);
		public const uint kMode                                    = (0x3599AEFAu);
		public const uint kMotor1                                  = (0x6B07B61Bu);
		public const uint kMotor2                                  = (0x6B07B61Au);
		public const uint kMotor3                                  = (0x6B07B619u);
		public const uint kMotor4                                  = (0x6B07B618u);
		public const uint kMs                                      = (0x004D132Bu);
		public const uint kNotStill                                = (0xE6F79B82u);
		public const uint kOffset                                  = (0xAA9DB3AEu);
		public const uint kOutdoor                                 = (0x64641338u);
		public const uint kOverruns                                = (0xFB186724u);
		public const uint kP                                       = (0x00000050u);
		public const uint kPageCount                               = (0xD9E446E4u);
		public const uint kPageNumber                              = (0x4F870AFFu);
		public const uint kParity                                  = (0x969F4792u);
		public const uint kPitch                                   = (0x88ABE54Bu);
		public const uint kPitchDerivative                         = (0xBA559312u);
		public const uint kPitchIntegral                           = (0x6EB50FF9u);
		public const uint kPitchProportional                       = (0x3A822007u);
		public const uint kPosition                                = (0xED4147C8u);
		public const uint kPressure                                = (0xB7F57350u);
		public const uint kProportional                            = (0x67642BC1u);
		public const uint kProportionalClamp                       = (0x65032F95u);
		public const uint kQuality                                 = (0x77760609u);
		public const uint kRate                                    = (0x1766CD66u);
		public const uint kResolution                              = (0xE37C12F0u);
		public const uint kResponse                                = (0xCB065BC7u);
		public const uint kResult                                  = (0x07119F4Cu);
		public const uint kRight                                   = (0x0A2269BEu);
		public const uint kRightAmbient                            = (0x61A13BBDu);
		public const uint kRightCt                                 = (0x263540B8u);
		public const uint kRightResult                             = (0xDA980B61u);
		public const uint kRoll                                    = (0x1E43AF5Eu);
		public const uint kRollDerivative                          = (0x441EA01Au);
		public const uint kRollIntegral                            = (0xDE2934A0u);
		public const uint kRollProportional                        = (0x642022E2u);
		public const uint kSatellites                              = (0x3017454Fu);
		public const uint kSaturation                              = (0x2712F8E0u);
		public const uint kSensitivity                             = (0x96BFDA00u);
		public const uint kSensorsAccelerationGet                  = (0x516CBDF1u);
		public const uint kSensorsBatteryGet                       = (0x17340534u);
		public const uint kSensorsDistanceGet                      = (0xD565BE37u);
		public const uint kSensorsGpsGet                           = (0xC3F776CAu);
		public const uint kSensorsGyroGet                          = (0x44751FB9u);
		public const uint kSensorsMagnetometerGet                  = (0x9E845EA5u);
		public const uint kSensorsMotorsGet                        = (0xCAFCB0C7u);
		public const uint kSensorsPressureGet                      = (0x273BC739u);
		public const uint kSensorsProcessorTemperatureGet          = (0x6E38BE53u);
		public const uint kSensorsRawAccelerationGet               = (0xF461C662u);
		public const uint kSensorsSonarAltitudeGet                 = (0x7AFAC0D0u);
		public const uint kSensorsTemperatureGet                   = (0xE54953AEu);
		public const uint kSettings                                = (0x7CC144A2u);
		public const uint kSize                                    = (0x49E461A5u);
		public const uint kSpeed                                   = (0x92BFCAB8u);
		public const uint kSpeedX                                  = (0x751DDF0Cu);
		public const uint kSpeedY                                  = (0x751DDF0Fu);
		public const uint kSpeedZ                                  = (0x751DDF0Eu);
		public const uint kSystemAltitudePidGet                    = (0x3CF24194u);
		public const uint kSystemBandwidthGet                      = (0x9580401Au);
		public const uint kSystemBandwidthSet                      = (0x9B6914CFu);
		public const uint kSystemCalibratecompassSet               = (0x7BB06F4Eu);
		public const uint kSystemDebugSet                          = (0x791FCB17u);
		public const uint kSystemErrorsGet                         = (0xCFC891BAu);
		public const uint kSystemExpansionByteGet                  = (0x0C044B7Au);
		public const uint kSystemExpansionByteSet                  = (0x11ED1067u);
		public const uint kSystemExpansionConfigSet                = (0x119D0C99u);
		public const uint kSystemFlightPidGet                      = (0x24F8A08Cu);
		public const uint kSystemGpsPidGet                         = (0xC5933683u);
		public const uint kSystemInertialPidGet                    = (0xA9721884u);
		public const uint kSystemLastmessageGet                    = (0x786B2571u);
		public const uint kSystemMotorSet                          = (0xB8DA5CF0u);
		public const uint kSystemObstacleInternalsGet              = (0xC60E61D0u);
		public const uint kSystemObstaclePidGet                    = (0x86686D3Bu);
		public const uint kSystemTimeGet                           = (0xACDE1E0Au);
		public const uint kSystemTimeSet                           = (0xB2C7DE27u);
		public const uint kTemperature                             = (0x457AAF0Eu);
		public const uint kThreshold                               = (0x434B3360u);
		public const uint kThrust                                  = (0xD0AF7877u);
		public const uint kTime                                    = (0x785D8D90u);
		public const uint kTimeOut                                 = (0xCC7A167Bu);
		public const uint kTop                                     = (0x29CC1BD9u);
		public const uint kTopAmbient                              = (0x2A1D257Eu);
		public const uint kTopCt                                   = (0xAD6D25EBu);
		public const uint kTopResult                               = (0xB2F8E80Au);
		public const uint kTotal                                   = (0xAF836267u);
		public const uint kType                                    = (0x80416EDBu);
		public const uint kUseroutdoor                             = (0xCB802891u);
		public const uint kValue                                   = (0xA8200271u);
		public const uint kWaypointAdd                             = (0x8BD2B186u);
		public const uint kWaypointClearAll                        = (0x785A6109u);
		public const uint kWaypointCountGet                        = (0x6F454F6Fu);
		public const uint kWaypointGet                             = (0x8EC7196Eu);
		public const uint kWaypointId                              = (0xB7E9FDF5u);
		public const uint kWaypointMode                            = (0xD6CC185Cu);
		public const uint kWaypointPause                           = (0xF3C960A0u);
		public const uint kWaypointSet                             = (0x94B0C505u);
		public const uint kWaypointStart                           = (0x29B5D1E0u);
		public const uint kWaypointStop                            = (0xF077F338u);
		public const uint kWidth                                   = (0x5C524F54u);
		public const uint kX                                       = (0x00000058u);
		public const uint kXM                                      = (0x005815ADu);
		public const uint kXmax                                    = (0x34654789u);
		public const uint kXMax                                    = (0x24A3A76Fu);
		public const uint kXmin                                    = (0x346D41B7u);
		public const uint kXMin                                    = (0x24ABA111u);
		public const uint kY                                       = (0x00000059u);
		public const uint kYaw                                     = (0x2C34501Bu);
		public const uint kYawDerivative                           = (0xDBC279D4u);
		public const uint kYawIntegral                             = (0x4D945C0Fu);
		public const uint kYawProportional                         = (0xF2A2E976u);
		public const uint kYM                                      = (0x0059166Du);
		public const uint kYmax                                    = (0x62EC2647u);
		public const uint kYMax                                    = (0x532A07A1u);
		public const uint kYmin                                    = (0x62F4246Du);
		public const uint kYMin                                    = (0x5332054Bu);
		public const uint kZ                                       = (0x0000005Au);
		public const uint kZM                                      = (0x005A1629u);
		public const uint kZmax                                    = (0x91738419u);
		public const uint kZMax                                    = (0x81B1A4FBu);
		public const uint kZmin                                    = (0x917B8623u);
		public const uint kZMin                                    = (0x81B9A681u);
	}

	[SuppressUnmanagedCodeSecurityAttribute()]
	public class Library
	{
		public const String kLibraryName = "libZano"; 
		public const CallingConvention kCallingConvention = CallingConvention.Cdecl;

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Initialise"), SuppressUnmanagedCodeSecurity]
		extern public static int Initialise([MarshalAs(UnmanagedType.LPStr)] String apiKey);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Shutdown"), SuppressUnmanagedCodeSecurity]
		extern public static void Shutdown();


		// Obtain a Zano
		// desc.
		//   Obtain and try and connect to a Zano.
		// args.
		//   address -- The IP address or hostname of the Zano. 
		//              Set as NULL (or nullptr), or an empty string "" for the default Zano address: 192.168.0.1
		//   port    -- The port number of the Zano to connect to.
		//              Set as 0 to use the default Zano port: 10001
		// return.
		//   A handle to the Zano (from 1 to 255), if there was no Zano available or there was an error then 0 is returned.
		// see.
		//   Release
		// suggested-usage.
		//   > Zano_Handle zano = Zano_Obtain(NULL, 0);
		// 
		// Response Frames:
		//   1. Connected Succesfully
		//      Type: Connect
		//      Values:  
		//        Response = Connected
		//   2. Cannot Connect
		//      Type: Connect
		//      Values:  
		//        Response = CannotConnect
		// 
		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Obtain"), SuppressUnmanagedCodeSecurity]
		extern public static uint Obtain([MarshalAs(UnmanagedType.LPStr)] String address, int port);


		// Release
		// desc.
		//   Release connection from a Zano.
		// args.
		//   zano    -- The obtained Zano handle to disconnect.
		// see.
		//   Zano_Obtain
		// note.
		//   There will be a real amount of time that happens during a disconnection so the
		//   handle will be used but not available. Once the disconnection happens the handle
		//   may be recycled.
		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Release"), SuppressUnmanagedCodeSecurity]
		extern public static void Release(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Connect"), SuppressUnmanagedCodeSecurity]
		extern public static int Connect(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Disconnect"), SuppressUnmanagedCodeSecurity]
		extern public static int Disconnect(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsConnected"), SuppressUnmanagedCodeSecurity]
		extern public static int IsConnected(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsConnecting"), SuppressUnmanagedCodeSecurity]
		extern public static int IsConnecting(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsConfigured"), SuppressUnmanagedCodeSecurity]
		extern public static int IsConfigured(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetAccelOffsetConfiguration_X"), SuppressUnmanagedCodeSecurity]
		extern public static int GetAccelOffsetConfiguration_X(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetAccelOffsetConfiguration_Y"), SuppressUnmanagedCodeSecurity]
		extern public static int GetAccelOffsetConfiguration_Y(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetAccelOffsetConfiguration_Z"), SuppressUnmanagedCodeSecurity]
		extern public static int GetAccelOffsetConfiguration_Z(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsRecording"), SuppressUnmanagedCodeSecurity]
		extern public static int IsRecording(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Tick"), SuppressUnmanagedCodeSecurity]
		extern public static void Tick();


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Time"), SuppressUnmanagedCodeSecurity]
		extern public static ulong Time();


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_PingTime"), SuppressUnmanagedCodeSecurity]
		extern public static float PingTime(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Media_SendRate"), SuppressUnmanagedCodeSecurity]
		extern public static uint MediaSendRate(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SerialNumber"), SuppressUnmanagedCodeSecurity]
		extern public static long SerialNumber(uint zano);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SendFrame"), SuppressUnmanagedCodeSecurity]
		extern public static int Send(ref Frame frame);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_ReceiveFrame"), SuppressUnmanagedCodeSecurity]
		extern public static int Receive(ref Frame frame);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_TrackedSendFrame1"), SuppressUnmanagedCodeSecurity]
		extern public static int TrackedSendFrame1(ref Frame frame, byte userData, uint maxCount, uint resendTime);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_TrackedSendFrame2"), SuppressUnmanagedCodeSecurity]
		extern public static int TrackedSendFrame2(ref Frame frame1, ref Frame frame2, byte userData, uint maxCount, uint resendTime);


		public enum DisplayColour
		{
			Red         = 82,
			Green       = 71,
			Yellow      = 89,
			Blue        = 66,
			Magenta     = 77,
			Cyan        = 67,
			White       = 87,
			Transparent = 46
		}
		public enum Glyph
		{
			Block             ,
			FilledArrowNW     ,
			FilledArrowN      ,
			FilledArrowNE     ,
			FilledArrowE      ,
			FilledArrowSE     ,
			FilledArrowS      ,
			FilledArrowSW     ,
			FilledArrowW      ,
			EmptyArrowNW      ,
			EmptyArrowN       ,
			EmptyArrowNE      ,
			EmptyArrowE       ,
			EmptyArrowSE      ,
			EmptyArrowS       ,
			EmptyArrowSW      ,
			EmptyArrowW       ,
			Battery6          ,
			Battery5          ,
			Battery4          ,
			Battery3          ,
			Battery2          ,
			Battery1          ,
			Battery0          ,
			Home              ,
			Person            ,
			Plug              ,
			Earth             ,
			Heart             ,
			Checkmark         ,
			Cross             ,
			Target1           ,
			Target2           ,
			Star              ,
			Exclamation       ,
			Question          ,
			Lock              ,
			Unlock            ,
			Num1              ,
			Num2              ,
			Num3              ,
			Num4              ,
			Num5              ,
			Num6              ,
			Num7              ,
			Num8              ,
			Num9              ,
			Num0              ,
			Load1             ,
			Load2             ,
			Load3             ,
			Load4             ,
			Load5             ,
			Load6             ,
			Load7             ,
			Load8             ,
			Load9             ,
			Load10            ,
			Load11            ,
			Load12            ,
			Load13            ,
			Load14            ,
			Busy1             ,
			Busy2             ,
			SmileFace         ,
			SadFace           ,
			StraightFace      ,
			GrinFace          ,
			ShockedFace       ,
			Square            ,
			Triangle          ,
			Circle            ,
			A                 ,
			B                 ,
			C                 ,
			D                 ,
			Skull             ,
			ZanoFront         ,
			ZanoSide          ,
			Signal1           ,
			Signal2           ,
			Signal3           ,
			Signal4           ,
			H53               ,
			H54               ,
			H55               ,
			H56               ,
			H57               ,
			EmptyHeart        ,
			EmptyDiamond      ,
			FilledSpade       ,
			FilledClub        ,
			ChessPawn         ,
			ChessRook         ,
			ChessKnight       ,
			ChessBishop       ,
			ChessQueen        ,
			ChessKing         ,
			Dice1             ,
			Dice2             ,
			Dice3             ,
			Dice4             ,
			Dice5             ,
			Dice6             ,
			Mail              ,
			Droid             ,
			Apple             ,
			Cherry            ,
			Plum              ,
			Melon             ,
			MelonSlice        ,
			DiamondGem        ,
			Bell              ,
			StarBig           ,
			Filled7           ,
			Empty7            ,
			FourLeafClover    ,
			NoLimit           ,
			LightningBolt     ,
			Sunshine          ,
			Cloud             ,
			RainCloud         ,
			Snowflake         ,
			PowerOnOff        ,
			CoffeeCup         ,
			MusicNotes        ,
			MusicNote         ,
			FilledMoon        ,
			FilledCircleA     ,
			FilledCircleB     ,
			FilledCircleC     ,
			FilledCircleD     ,
			FilledCircleE     ,
			FilledCircleF     ,
			FilledCircle0     ,
			FilledCircle1     ,
			FilledCircle2     ,
			FilledCircle3     ,
			FilledCircle4     ,
			FilledCircle5     ,
			FilledCircle6     ,
			FilledCircle7     ,
			FilledCircle8     ,
			FilledCircle9     ,
			EmptyCircleA      ,
			EmptyCircleB      ,
			EmptyCircleC      ,
			EmptyCircleD      ,
			EmptyCircleE      ,
			EmptyCircleF      ,
			EmptyCircle0      ,
			EmptyCircle1      ,
			EmptyCircle2      ,
			EmptyCircle3      ,
			EmptyCircle4      ,
			EmptyCircle5      ,
			EmptyCircle6      ,
			EmptyCircle7      ,
			EmptyCircle8      ,
			EmptyCircle9      ,
			FlagA             ,
			FlagB             ,
			FlagC             ,
			FlagD             ,
			FlagE             ,
			FlagF             ,
			Flag0             ,
			Flag1             ,
			Flag2             ,
			Flag3             ,
			Flag4             ,
			Flag5             ,
			Flag6             ,
			Flag7             ,
			Flag8             ,
			Flag9             ,
			AstroSun          ,
			AstroMoon         ,
			AstroMars         ,
			AstroJupiter      ,
			AstroVenus        ,
			AstroSaturn       ,
			AstroMercury      ,
			ZodiacAries       ,
			ZodiacTaurus      ,
			ZodiacGemini      ,
			ZodiacCancer      ,
			ZodiacLeo         ,
			ZodiacVirgo       ,
			ZodiacLibra       ,
			ZodiacScorpio     ,
			ZodiacSagittarius ,
			ZodiacCapricorn   ,
			ZodiacAquarius    ,
			ZodiacPisces      ,
			AstroEarth        ,
			FaceMouse         ,
			FacenStein        ,
			FaceVampire       ,
			Alien1            ,
			Alien2            ,
			FaceBallHappy     ,
			FaceBallSad       ,
			FaceBallStraight  ,
			FaceBallWinkySmile,
			Play              ,
			Pause             ,
			Collision         ,
			Rewind            ,
			FastForward       ,
			Airplane          ,
			YinYang           ,
			TennisBall        ,
			Go                ,
			Car               ,
			Lorry             ,
			BrokenHeart       ,
			Telephone         ,
			Swordsman1        ,
			Swordsman2        ,
			Swordsman3        ,
			Swordsman4        ,
			UTurn             ,
			EmptyCircleBig    ,
			Launch            ,
			BusyA1            ,
			BusyA2            ,
			BusyA3            ,
			BusyA4            ,
			GPS               ,
			FilledCircleBig   ,
			Land              ,
			Clock             ,
			Rocket            ,
			Reboot            ,
			Camera            ,
			Video             ,
			Vibration         ,
			Sleep1            ,
			Sleep2            ,
			SocialB           ,
			SocialG           ,
			SocialIn          ,
			SocialP           ,
			SocialBird        ,
			SocialF           ,
			GPSMarker         ,
			Satellite         ,
			Spanner           ,
			CentreOfGravity   ,
			Helipad           ,
			ZanoZ             ,
			ZanoA             ,
			ZanoN             ,
			ZanoO             ,
			ZanoTriangle      
		}
		public enum Status
		{
			None                                              = 0,
			FlashingStarted                                   = 101,
			FlashingProcessSucessfull                         = 102,
			FlashingProcessFailed                             = 103,
			ConfigurationStarting                             = 201,
			ConfigurationApplied                              = 202,
			ConfigurationNotNeeded                            = 203,
			ConfigurationDoesNotExist                         = 204,
			HelloRequested                                    = 301,
			HelloSuccess                                      = 302,
			HelloFailed                                       = 303,
			FirmwareDownloadingRequested                      = 401,
			FirmwareDownloadedNew                             = 402,
			FirmwareDownloadedUpToDate                        = 403,
			FirmwareDownloadedNetworkError                    = 404,
			ConfigurationRequest                              = 501,
			ConfigurationNetworkError                         = 502,
			ConfigurationAuthenticationError                  = 503,
			ConfigurationNoConfigurationAssociatedWithAccount = 504,
			ConfigurationDownloaded                           = 505,
			DeviceConnectionAttempt                           = 701,
			DeviceConnectionGotConnection                     = 702,
			DeviceConnectionBooted                            = 703,
			DeviceConnectionInRecovery                        = 704,
			DeviceConnectionHeldStill                         = 705,
			DeviceConnectionBootFailure                       = 706,
			DeviceConnectionNeedToUpdate                      = 707,
			DeviceConnectionConnected                         = 708,
			DeviceConnectionNotConnected                      = 709,
			DeviceConnectionBadUpdate                         = 710,
			DeviceConnectionDroneNotAssociatedWithAccount     = 711,
			DeviceConnectionPeekConnected                     = 712,
			DeviceDisconnectionDisconnected                   = 801,
			ServerConnectivityLoginSuccess                    = 1001,
			ServerConnectivityLoginFailure                    = 1002
		}

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetStatus"), SuppressUnmanagedCodeSecurity]
		extern public static Status GetStatus();


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Display"), SuppressUnmanagedCodeSecurity]
		extern public static int Display(uint handle, [MarshalAs(UnmanagedType.LPStr)] String animationStr);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_DisplayPrint"), SuppressUnmanagedCodeSecurity]
		extern public static int DisplayPrint(uint handle, [MarshalAs(UnmanagedType.LPStr)] String text, byte time, DisplayColour foreground, DisplayColour background);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_DisplayGlyph"), SuppressUnmanagedCodeSecurity]
		extern public static int DisplayGlyph(uint handle, Glyph glyph, byte time, DisplayColour foreground, DisplayColour background);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_DisplayGlyphs"), SuppressUnmanagedCodeSecurity]
		extern public static int DisplayGlyphs(uint handle, Glyph[] glyphs, uint count, byte time, DisplayColour foreground, DisplayColour background);

		public const int kPathVideo   = 1;
		public const int kPathPicture = 2;
		public const int kPathAudio   = 4;
		public const int kPathData    = 8;
		public const int kPathTemp    = 16;

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SetPath"), SuppressUnmanagedCodeSecurity]
		extern public static int SetPath(int pathName, [MarshalAs(UnmanagedType.LPStr)] String path);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetPath"), SuppressUnmanagedCodeSecurity]
		extern public static String GetPath(int pathName);

		[UnmanagedFunctionPointer(Library.kCallingConvention)]
		public delegate void ErrorCallback(uint handle, uint errorCode, [MarshalAs(UnmanagedType.LPStr)] String errorString);

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SetErrorCallback"), SuppressUnmanagedCodeSecurity]
		extern public static void SetErrorCallback(ErrorCallback callback);

		public enum ConnectionState
		{
			NotConnected   ,
			Connected      ,
			StillConnecting,
			Debug          
		}
		public enum DebugConnectionState
		{
			None                                     ,
			AskingForVersion                         ,
			BadFirmwareFound                         ,
			BadUpgrade                               ,
			Booted                                   ,
			BootedIntoFirmware                       ,
			BootFailure                              ,
			Booting                                  ,
			CannotBoot                               ,
			Connected                                ,
			DroneBeingMoved                          ,
			LoadedAPI                                ,
			LoadedAPITimeout                         ,
			LoadedConstants                          ,
			LoadedConstantsTimeout                   ,
			LoadedErrors                             ,
			LoadedErrorsTimeout                      ,
			LoadingAPI                               ,
			LoadingConstants                         ,
			LoadingErrors                            ,
			NoFirmwareAvailableToUpgradeAndCannotBoot,
			NoFirmwareFoundAfterBooting              ,
			NotBooting                               ,
			NotConnected                             ,
			StartingRecovery                         ,
			EstablishedConnection                    ,
			EstablishingConnection                   ,
			TimeoutAfterBooting                      ,
			UnexpectedAPI                            ,
			UpgradeFailedManyTimes                   ,
			WillUpgrade                              
		}
		public enum FlyState
		{
			False,
			True 
		}
		public enum FlyStateReason
		{
			None                 ,
			MissingConfiguration ,
			UpdatingConfiguration
		}

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetFirmwareVersion"), SuppressUnmanagedCodeSecurity]
		extern public static void GetFirmwareVersion(uint handle, ref Version version);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetBootloaderVersion"), SuppressUnmanagedCodeSecurity]
		extern public static void GetBootloaderVersion(uint handle, ref Version version);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetLibZanoVersion"), SuppressUnmanagedCodeSecurity]
		extern public static void GetLibZanoVersion(ref Version version);


	}

	[StructLayout(LayoutKind.Sequential)]
	public struct Version
	{
		public int Major;
		public int Minor;
		public int Revision;
		public int Hardware;
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Frame
	{		public Frame(uint handle)
		{
			Handle = handle;
			Timestamp = 0;
			Type = 0;
			Reference = 0;
			UserData = 0;
			Names = new uint[16];
			Values = new int[16];
		}
		public const int kSendFrame = 0;
		public const int kConnectFrame = 1;
		public const int kDisconnectFrame = 2;
		public const int kFlyStateFrame = 3;
		public const int kServerConnectivity = 4;
		public const int kFirmware = 5;

		public uint Handle;
		public ulong Timestamp;
		public int Type;
		public uint Reference;
		public uint UserData;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public uint[] Names;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public int[] Values;

		public int Get(uint symbol)
		{
			for(int i = 0;i < 16;i++)
			{
				if(Names[i] == symbol)
				{
					return Values[i];
				}
			}
			return 0;
		}


	}
	[StructLayout(LayoutKind.Sequential)]
	public struct Media
	{
		public enum Resolution
		{
			At_2500x2000 = 0,
			At_1920x1080 = 1,
			At_1280x720  = 2,
			At_960x720   = 3,
			At_640x480   = 4,
			At_400x300   = 5,
			At_320x240   = 6
		}

		public const int kMediaTypeNone        = 0;
		public const int kMediaTypeJpegVideo   = 1;
		public const int kMediaTypeJpegPicture = 2;

		public enum RecordState
		{
			None     = 0,
			Recorded = 1,
			Failed   = 2
		}

		public IntPtr Data;
		public uint Size;
		public uint Frame;
		public uint Time;
		public ulong LocalTime;
		public uint Handle;
		public int Type;
		public ushort ImageWidth;
		public ushort ImageHeight;

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StartCamera"), SuppressUnmanagedCodeSecurity]
		extern public static void StartCamera(uint handle, Resolution resolution, float fps);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StopCamera"), SuppressUnmanagedCodeSecurity]
		extern public static void StopCamera(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_Snapshot"), SuppressUnmanagedCodeSecurity]
		extern public static void Snapshot(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SnapshotCountLeft"), SuppressUnmanagedCodeSecurity]
		extern public static int SnapshotCountLeft(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StartStreaming"), SuppressUnmanagedCodeSecurity]
		extern public static void StartStreaming(uint handle, int mediaTypes);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StopStreaming"), SuppressUnmanagedCodeSecurity]
		extern public static void StopStreaming(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsStreaming"), SuppressUnmanagedCodeSecurity]
		extern public static int IsStreaming(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_GetStreamingMedia"), SuppressUnmanagedCodeSecurity]
		extern public static int GetStreamingMedia();

		[UnmanagedFunctionPointer(Library.kCallingConvention)]
		public delegate void StreamingCallback(ref Media media);

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StartStreamingCallback"), SuppressUnmanagedCodeSecurity]
		extern public static void StartStreamingCallback(uint handle, StreamingCallback callback, int mediaTypes);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StopStreamingCallback"), SuppressUnmanagedCodeSecurity]
		extern public static void StopStreamingCallback(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsStreamingCallback"), SuppressUnmanagedCodeSecurity]
		extern public static int IsStreamingCallback(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StartRecording"), SuppressUnmanagedCodeSecurity]
		extern public static void StartRecording(uint handle, int mediaTypes);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_StopRecording"), SuppressUnmanagedCodeSecurity]
		extern public static void StopRecording(uint handle);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_IsRecording"), SuppressUnmanagedCodeSecurity]
		extern public static int IsRecording(uint handle);

		[UnmanagedFunctionPointer(Library.kCallingConvention)]
		public delegate void RecordingCallback(String path, int mediaType, ushort width, ushort height);

		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_SetRecordingCallback"), SuppressUnmanagedCodeSecurity]
		extern public static void SetRecordingCallback(uint handle, RecordingCallback callback, int mediaTypes);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_ClearRecordingCallback"), SuppressUnmanagedCodeSecurity]
		extern public static void ClearRecordingCallback(uint handle);

	}

	public static class ServerConnectivity
	{
		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_ServerConnectivity_Credentials"), SuppressUnmanagedCodeSecurity]
		extern public static void Credentials([MarshalAs(UnmanagedType.LPStr)] String email, [MarshalAs(UnmanagedType.LPStr)] String password);


		[DllImport(Library.kLibraryName, CallingConvention = Library.kCallingConvention, EntryPoint = "Zano_ServerConnectivity_Refresh"), SuppressUnmanagedCodeSecurity]
		extern public static void Refresh();

	}

	public class Frames
	{
		///<command>
		///	<name>messages.get</name>
		///	<symbol>kMessagesGet</symbol>
		///	<scope>messages</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kIndex">Index</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kIndex">Index</response>
		///		<response type="byte" symbol="kCount">Count</response>
		///		<response type="ushort" symbol="kLength">Length</response>
		///	</responses>
		///</command>
		public static void MessagesGet(uint handle, byte index)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kMessagesGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kIndex;
				sendFrame.Values[0] = (int) index;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>constants.get</name>
		///	<symbol>kConstantsGet</symbol>
		///	<scope>constants</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kIndex">Index</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kIndex">Index</response>
		///		<response type="byte" symbol="kCount">Count</response>
		///		<response type="ushort" symbol="kLength">Length</response>
		///	</responses>
		///</command>
		public static void ConstantsGet(uint handle, byte index)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConstantsGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kIndex;
				sendFrame.Values[0] = (int) index;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.altitude.get</name>
		///	<symbol>kFlightAltitudeGet</symbol>
		///	<scope>flight.altitude</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kAltitude">Altitude</response>
		///		<response type="int" symbol="kAltitudeTarget">AltitudeTarget</response>
		///	</responses>
		///	<see>flight.altitude.set</see>
		///</command>
		public static void FlightAltitudeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightAltitudeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.altitude.set</name>
		///	<symbol>kFlightAltitudeSet</symbol>
		///	<scope>flight.altitude</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="int" symbol="kAltitude">Altitude</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kAltitude">Altitude</response>
		///	</responses>
		///	<see>flight.altitude.get</see>
		///</command>
		public static void FlightAltitudeSet(uint handle, int altitude)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightAltitudeSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kAltitude;
				sendFrame.Values[0] = (int) altitude;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.heading.get</name>
		///	<symbol>kFlightHeadingGet</symbol>
		///	<scope>flight.heading</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kHeading">Heading</response>
		///	</responses>
		///	<see>flight.heading.set</see>
		///</command>
		public static void FlightHeadingGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightHeadingGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.heading.set</name>
		///	<symbol>kFlightHeadingSet</symbol>
		///	<scope>flight.heading</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kHeading">Heading</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kHeading">Heading</response>
		///	</responses>
		///	<see>flight.heading.get</see>
		///</command>
		public static void FlightHeadingSet(uint handle, short heading)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightHeadingSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kHeading;
				sendFrame.Values[0] = (int) heading;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.isoutdoor.get</name>
		///	<symbol>kFlightIsoutdoorGet</symbol>
		///	<scope>flight.isoutdoor</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kUseroutdoor">Useroutdoor</response>
		///		<response type="byte" symbol="kOutdoor">Outdoor</response>
		///	</responses>
		///	<see>flight.isoutdoor.set</see>
		///</command>
		public static void FlightIsoutdoorGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightIsoutdoorGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.isoutdoor.set</name>
		///	<symbol>kFlightIsoutdoorSet</symbol>
		///	<scope>flight.isoutdoor</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kOutdoor">Outdoor</arg>
		///	</arguments>
		///	<see>flight.isoutdoor.get</see>
		///</command>
		public static void FlightIsoutdoorSet(uint handle, byte outdoor)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightIsoutdoorSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kOutdoor;
				sendFrame.Values[0] = (int) outdoor;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.pitch.get</name>
		///	<symbol>kFlightPitchGet</symbol>
		///	<scope>flight.pitch</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kPitch">Pitch</response>
		///	</responses>
		///	<see>flight.pitch.set</see>
		///</command>
		public static void FlightPitchGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightPitchGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.pitch.set</name>
		///	<symbol>kFlightPitchSet</symbol>
		///	<scope>flight.pitch</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kPitch">Pitch</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kPitch">Pitch</response>
		///	</responses>
		///	<see>flight.pitch.get</see>
		///</command>
		public static void FlightPitchSet(uint handle, short pitch)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightPitchSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kPitch;
				sendFrame.Values[0] = (int) pitch;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.roll.get</name>
		///	<symbol>kFlightRollGet</symbol>
		///	<scope>flight.roll</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kRoll">Roll</response>
		///	</responses>
		///	<see>flight.roll.set</see>
		///</command>
		public static void FlightRollGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightRollGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.roll.set</name>
		///	<symbol>kFlightRollSet</symbol>
		///	<scope>flight.roll</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kRoll">Roll</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kRoll">Roll</response>
		///	</responses>
		///	<see>flight.roll.get</see>
		///</command>
		public static void FlightRollSet(uint handle, short roll)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightRollSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kRoll;
				sendFrame.Values[0] = (int) roll;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.thrust.get</name>
		///	<symbol>kFlightThrustGet</symbol>
		///	<scope>flight.thrust</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kThrust">Thrust</response>
		///	</responses>
		///	<see>flight.thrust.set</see>
		///</command>
		public static void FlightThrustGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightThrustGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.thrust.set</name>
		///	<symbol>kFlightThrustSet</symbol>
		///	<scope>flight.thrust</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kThrust">Thrust</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kThrust">Thrust</response>
		///	</responses>
		///	<see>flight.thrust.get</see>
		///</command>
		public static void FlightThrustSet(uint handle, short thrust)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightThrustSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kThrust;
				sendFrame.Values[0] = (int) thrust;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.mode.get</name>
		///	<symbol>kFlightModeGet</symbol>
		///	<scope>flight.mode</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kMode">Mode</response>
		///	</responses>
		///	<see>flight.mode.set</see>
		///</command>
		public static void FlightModeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightModeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.mode.set</name>
		///	<symbol>kFlightModeSet</symbol>
		///	<scope>flight.mode</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kMode">Mode</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>flight.mode.get</see>
		///</command>
		public static void FlightModeSet(uint handle, byte mode)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightModeSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMode;
				sendFrame.Values[0] = (int) mode;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.auto.pitch.set</name>
		///	<symbol>kFlightAutoPitchSet</symbol>
		///	<scope>flight.auto.pitch</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kPitch">Pitch</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kPitch">Pitch</response>
		///	</responses>
		///</command>
		public static void FlightAutoPitchSet(uint handle, short pitch)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightAutoPitchSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kPitch;
				sendFrame.Values[0] = (int) pitch;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.auto.roll.set</name>
		///	<symbol>kFlightAutoRollSet</symbol>
		///	<scope>flight.auto.roll</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kRoll">Roll</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kRoll">Roll</response>
		///	</responses>
		///</command>
		public static void FlightAutoRollSet(uint handle, short roll)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightAutoRollSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kRoll;
				sendFrame.Values[0] = (int) roll;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.relative.altitude.set</name>
		///	<symbol>kFlightRelativeAltitudeSet</symbol>
		///	<scope>flight.relative.altitude</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kDeltaAltitude">DeltaAltitude</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kAltitude">Altitude</response>
		///	</responses>
		///</command>
		public static void FlightRelativeAltitudeSet(uint handle, short deltaaltitude)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightRelativeAltitudeSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kDeltaAltitude;
				sendFrame.Values[0] = (int) deltaaltitude;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.relative.heading.set</name>
		///	<symbol>kFlightRelativeHeadingSet</symbol>
		///	<scope>flight.relative.heading</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kDeltaHeading">DeltaHeading</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kHeading">Heading</response>
		///	</responses>
		///</command>
		public static void FlightRelativeHeadingSet(uint handle, short deltaheading)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightRelativeHeadingSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kDeltaHeading;
				sendFrame.Values[0] = (int) deltaheading;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.control.invert.get</name>
		///	<symbol>kFlightControlInvertGet</symbol>
		///	<scope>flight.control.invert</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kFlag">Flag</response>
		///	</responses>
		///	<see>flight.control.invert.set</see>
		///</command>
		public static void FlightControlInvertGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightControlInvertGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.control.invert.set</name>
		///	<symbol>kFlightControlInvertSet</symbol>
		///	<scope>flight.control.invert</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kFlag">Flag</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>flight.control.invert.get</see>
		///</command>
		public static void FlightControlInvertSet(uint handle, byte flag)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightControlInvertSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kFlag;
				sendFrame.Values[0] = (int) flag;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.launch</name>
		///	<symbol>kFlightLaunch</symbol>
		///	<scope>flight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>flight.land</see>
		///	<see>flight.rth</see>
		///	<see>flight.quicksnap</see>
		///</command>
		public static void FlightLaunch(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightLaunch;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.land</name>
		///	<symbol>kFlightLand</symbol>
		///	<scope>flight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>flight.launch</see>
		///	<see>flight.rth</see>
		///	<see>flight.quicksnap</see>
		///</command>
		public static void FlightLand(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightLand;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.rth</name>
		///	<symbol>kFlightRth</symbol>
		///	<scope>flight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>flight.launch</see>
		///	<see>flight.land</see>
		///	<see>flight.quicksnap</see>
		///</command>
		public static void FlightRth(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightRth;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>flight.quicksnap</name>
		///	<symbol>kFlightQuicksnap</symbol>
		///	<scope>flight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kDistance">Distance</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>flight.launch</see>
		///	<see>flight.land</see>
		///	<see>flight.rth</see>
		///</command>
		public static void FlightQuicksnap(uint handle, ushort distance)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kFlightQuicksnap;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kDistance;
				sendFrame.Values[0] = (int) distance;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>lights.landing.get</name>
		///	<symbol>kLightsLandingGet</symbol>
		///	<scope>lights.landing</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kColour">Colour</response>
		///	</responses>
		///	<see>lights.landing.set</see>
		///</command>
		public static void LightsLandingGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kLightsLandingGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>lights.landing.set</name>
		///	<symbol>kLightsLandingSet</symbol>
		///	<scope>lights.landing</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kColour">Colour</arg>
		///	</arguments>
		///	<see>lights.landing.get</see>
		///</command>
		public static void LightsLandingSet(uint handle, byte colour)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kLightsLandingSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kColour;
				sendFrame.Values[0] = (int) colour;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>media.recv</name>
		///	<symbol>kMediaRecv</symbol>
		///	<scope>media</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kType">Type</response>
		///		<response type="uint" symbol="kTime">Time</response>
		///		<response type="uint" symbol="kFrame">Frame</response>
		///		<response type="uint" symbol="kLength">Length</response>
		///		<response type="uint" symbol="kOffset">Offset</response>
		///		<response type="ushort" symbol="kFragmentSize">FragmentSize</response>
		///	</responses>
		///	<see>media.get</see>
		///</command>
		public static void MediaRecv(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kMediaRecv;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>media.get</name>
		///	<symbol>kMediaGet</symbol>
		///	<scope>media</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kType">Type</arg>
		///		<arg type="uint" symbol="kFrame">Frame</arg>
		///	</arguments>
		///	<see>media.recv</see>
		///</command>
		public static void MediaGet(uint handle, ushort type, uint frame)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kMediaGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kType;
				sendFrame.Values[0] = (int) type;
				sendFrame.Names[1] = Symbols.kFrame;
				sendFrame.Values[1] = (int) frame;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.acceleration.get</name>
		///	<symbol>kSensorsAccelerationGet</symbol>
		///	<scope>sensors.acceleration</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///		<response type="int" symbol="kSpeedX">SpeedX</response>
		///		<response type="int" symbol="kSpeedY">SpeedY</response>
		///		<response type="int" symbol="kSpeedZ">SpeedZ</response>
		///		<response type="int" symbol="kDistanceX">DistanceX</response>
		///		<response type="int" symbol="kDistanceY">DistanceY</response>
		///		<response type="int" symbol="kDistanceZ">DistanceZ</response>
		///	</responses>
		///</command>
		public static void SensorsAccelerationGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsAccelerationGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.battery.get</name>
		///	<symbol>kSensorsBatteryGet</symbol>
		///	<scope>sensors.battery</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kCharge">Charge</response>
		///	</responses>
		///</command>
		public static void SensorsBatteryGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsBatteryGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.distance.get</name>
		///	<symbol>kSensorsDistanceGet</symbol>
		///	<scope>sensors.distance</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kBack">Back</response>
		///		<response type="ushort" symbol="kFront">Front</response>
		///		<response type="ushort" symbol="kLeft">Left</response>
		///		<response type="ushort" symbol="kRight">Right</response>
		///		<response type="ushort" symbol="kTop">Top</response>
		///	</responses>
		///</command>
		public static void SensorsDistanceGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsDistanceGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.gyro.get</name>
		///	<symbol>kSensorsGyroGet</symbol>
		///	<scope>sensors.gyro</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///	</responses>
		///</command>
		public static void SensorsGyroGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsGyroGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.magnetometer.get</name>
		///	<symbol>kSensorsMagnetometerGet</symbol>
		///	<scope>sensors.magnetometer</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///	</responses>
		///</command>
		public static void SensorsMagnetometerGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsMagnetometerGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.motors.get</name>
		///	<symbol>kSensorsMotorsGet</symbol>
		///	<scope>sensors.motors</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kMotor1">Motor1</response>
		///		<response type="short" symbol="kMotor2">Motor2</response>
		///		<response type="short" symbol="kMotor3">Motor3</response>
		///		<response type="short" symbol="kMotor4">Motor4</response>
		///	</responses>
		///</command>
		public static void SensorsMotorsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsMotorsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.pressure.get</name>
		///	<symbol>kSensorsPressureGet</symbol>
		///	<scope>sensors.pressure</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kPressure">Pressure</response>
		///		<response type="int" symbol="kAltitude">Altitude</response>
		///	</responses>
		///</command>
		public static void SensorsPressureGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsPressureGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.processor.temperature.get</name>
		///	<symbol>kSensorsProcessorTemperatureGet</symbol>
		///	<scope>sensors.processor.temperature</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kTemperature">Temperature</response>
		///	</responses>
		///</command>
		public static void SensorsProcessorTemperatureGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsProcessorTemperatureGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.raw.acceleration.get</name>
		///	<symbol>kSensorsRawAccelerationGet</symbol>
		///	<scope>sensors.raw.acceleration</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///	</responses>
		///</command>
		public static void SensorsRawAccelerationGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsRawAccelerationGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.sonar.altitude.get</name>
		///	<symbol>kSensorsSonarAltitudeGet</symbol>
		///	<scope>sensors.sonar.altitude</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kAltitude">Altitude</response>
		///	</responses>
		///</command>
		public static void SensorsSonarAltitudeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsSonarAltitudeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.temperature.get</name>
		///	<symbol>kSensorsTemperatureGet</symbol>
		///	<scope>sensors.temperature</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kTemperature">Temperature</response>
		///	</responses>
		///</command>
		public static void SensorsTemperatureGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsTemperatureGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>sensors.gps.get</name>
		///	<symbol>kSensorsGpsGet</symbol>
		///	<scope>sensors.gps</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kLatitude">Latitude</response>
		///		<response type="int" symbol="kLongitude">Longitude</response>
		///		<response type="int" symbol="kAltitude">Altitude</response>
		///		<response type="byte" symbol="kSatellites">Satellites</response>
		///		<response type="byte" symbol="kQuality">Quality</response>
		///		<response type="ushort" symbol="kResolution">Resolution</response>
		///		<response type="uint" symbol="kTime">Time</response>
		///		<response type="uint" symbol="kCount">Count</response>
		///		<response type="ushort" symbol="kSpeed">Speed</response>
		///		<response type="short" symbol="kHeading">Heading</response>
		///		<response type="ushort" symbol="kHDOP">HDOP</response>
		///		<response type="short" symbol="kHeadingAdjust">HeadingAdjust</response>
		///	</responses>
		///</command>
		public static void SensorsGpsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSensorsGpsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.clear.all</name>
		///	<symbol>kWaypointClearAll</symbol>
		///	<scope>waypoint.clear</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///</command>
		public static void WaypointClearAll(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointClearAll;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.count.get</name>
		///	<symbol>kWaypointCountGet</symbol>
		///	<scope>waypoint.count</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kTotal">Total</response>
		///		<response type="ushort" symbol="kCompletedCount">CompletedCount</response>
		///	</responses>
		///</command>
		public static void WaypointCountGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointCountGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.add</name>
		///	<symbol>kWaypointAdd</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="int" symbol="kLatitude">Latitude</arg>
		///		<arg type="int" symbol="kLongitude">Longitude</arg>
		///		<arg type="int" symbol="kLatitudeDirection">LatitudeDirection</arg>
		///		<arg type="int" symbol="kLongitudeDirection">LongitudeDirection</arg>
		///		<arg type="int" symbol="kAltitude">Altitude</arg>
		///		<arg type="uint" symbol="kType">Type</arg>
		///		<arg type="uint" symbol="kFlags">Flags</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kWaypointId">WaypointId</response>
		///	</responses>
		///	<see>waypoint.get</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.start</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointAdd(uint handle, int latitude, int longitude, int latitudedirection, int longitudedirection, int altitude, uint type, uint flags)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointAdd;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kLatitude;
				sendFrame.Values[0] = (int) latitude;
				sendFrame.Names[1] = Symbols.kLongitude;
				sendFrame.Values[1] = (int) longitude;
				sendFrame.Names[2] = Symbols.kLatitudeDirection;
				sendFrame.Values[2] = (int) latitudedirection;
				sendFrame.Names[3] = Symbols.kLongitudeDirection;
				sendFrame.Values[3] = (int) longitudedirection;
				sendFrame.Names[4] = Symbols.kAltitude;
				sendFrame.Values[4] = (int) altitude;
				sendFrame.Names[5] = Symbols.kType;
				sendFrame.Values[5] = (int) type;
				sendFrame.Names[6] = Symbols.kFlags;
				sendFrame.Values[6] = (int) flags;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.get</name>
		///	<symbol>kWaypointGet</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kWaypointId">WaypointId</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kWaypointId">WaypointId</response>
		///		<response type="int" symbol="kLatitude">Latitude</response>
		///		<response type="int" symbol="kLongitude">Longitude</response>
		///		<response type="int" symbol="kLatitudeDirection">LatitudeDirection</response>
		///		<response type="int" symbol="kLongitudeDirection">LongitudeDirection</response>
		///		<response type="int" symbol="kAltitude">Altitude</response>
		///		<response type="uint" symbol="kType">Type</response>
		///		<response type="uint" symbol="kFlags">Flags</response>
		///	</responses>
		///	<see>waypoint.add</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.start</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointGet(uint handle, ushort waypointid)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kWaypointId;
				sendFrame.Values[0] = (int) waypointid;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.mode</name>
		///	<symbol>kWaypointMode</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kCount">Count</response>
		///		<response type="ushort" symbol="kCompletedCount">CompletedCount</response>
		///	</responses>
		///	<see>waypoint.add</see>
		///	<see>waypoint.get</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.start</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointMode(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointMode;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.pause</name>
		///	<symbol>kWaypointPause</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<see>waypoint.add</see>
		///	<see>waypoint.get</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.start</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointPause(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointPause;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.set</name>
		///	<symbol>kWaypointSet</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kWaypointId">WaypointId</arg>
		///		<arg type="int" symbol="kLatitude">Latitude</arg>
		///		<arg type="int" symbol="kLongitude">Longitude</arg>
		///		<arg type="int" symbol="kLatitudeDirection">LatitudeDirection</arg>
		///		<arg type="int" symbol="kLongitudeDirection">LongitudeDirection</arg>
		///		<arg type="int" symbol="kAltitude">Altitude</arg>
		///		<arg type="uint" symbol="kType">Type</arg>
		///		<arg type="uint" symbol="kFlags">Flags</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kid">id</response>
		///	</responses>
		///	<see>waypoint.add</see>
		///	<see>waypoint.get</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.start</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointSet(uint handle, ushort waypointid, int latitude, int longitude, int latitudedirection, int longitudedirection, int altitude, uint type, uint flags)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kWaypointId;
				sendFrame.Values[0] = (int) waypointid;
				sendFrame.Names[1] = Symbols.kLatitude;
				sendFrame.Values[1] = (int) latitude;
				sendFrame.Names[2] = Symbols.kLongitude;
				sendFrame.Values[2] = (int) longitude;
				sendFrame.Names[3] = Symbols.kLatitudeDirection;
				sendFrame.Values[3] = (int) latitudedirection;
				sendFrame.Names[4] = Symbols.kLongitudeDirection;
				sendFrame.Values[4] = (int) longitudedirection;
				sendFrame.Names[5] = Symbols.kAltitude;
				sendFrame.Values[5] = (int) altitude;
				sendFrame.Names[6] = Symbols.kType;
				sendFrame.Values[6] = (int) type;
				sendFrame.Names[7] = Symbols.kFlags;
				sendFrame.Values[7] = (int) flags;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.start</name>
		///	<symbol>kWaypointStart</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<see>waypoint.add</see>
		///	<see>waypoint.get</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.stop</see>
		///</command>
		public static void WaypointStart(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointStart;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>waypoint.stop</name>
		///	<symbol>kWaypointStop</symbol>
		///	<scope>waypoint</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<see>waypoint.add</see>
		///	<see>waypoint.get</see>
		///	<see>waypoint.mode</see>
		///	<see>waypoint.pause</see>
		///	<see>waypoint.set</see>
		///	<see>waypoint.start</see>
		///</command>
		public static void WaypointStop(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kWaypointStop;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.errors.get</name>
		///	<symbol>kSystemErrorsGet</symbol>
		///	<scope>system.errors</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kMessage">Message</response>
		///		<response type="uint" symbol="kOverruns">Overruns</response>
		///		<response type="uint" symbol="kParity">Parity</response>
		///	</responses>
		///</command>
		public static void SystemErrorsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemErrorsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.flight.pid.get</name>
		///	<symbol>kSystemFlightPidGet</symbol>
		///	<scope>system.flight.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kPitchProportional">PitchProportional</response>
		///		<response type="int" symbol="kPitchIntegral">PitchIntegral</response>
		///		<response type="int" symbol="kPitchDerivative">PitchDerivative</response>
		///		<response type="int" symbol="kRollProportional">RollProportional</response>
		///		<response type="int" symbol="kRollIntegral">RollIntegral</response>
		///		<response type="int" symbol="kRollDerivative">RollDerivative</response>
		///		<response type="int" symbol="kYawProportional">YawProportional</response>
		///		<response type="int" symbol="kYawIntegral">YawIntegral</response>
		///		<response type="int" symbol="kYawDerivative">YawDerivative</response>
		///	</responses>
		///</command>
		public static void SystemFlightPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemFlightPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.gps.pid.get</name>
		///	<symbol>kSystemGpsPidGet</symbol>
		///	<scope>system.gps.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kPitchProportional">PitchProportional</response>
		///		<response type="int" symbol="kPitchIntegral">PitchIntegral</response>
		///		<response type="int" symbol="kPitchDerivative">PitchDerivative</response>
		///		<response type="int" symbol="kRollProportional">RollProportional</response>
		///		<response type="int" symbol="kRollIntegral">RollIntegral</response>
		///		<response type="int" symbol="kRollDerivative">RollDerivative</response>
		///		<response type="int" symbol="kYawProportional">YawProportional</response>
		///		<response type="int" symbol="kYawIntegral">YawIntegral</response>
		///		<response type="int" symbol="kYawDerivative">YawDerivative</response>
		///	</responses>
		///</command>
		public static void SystemGpsPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemGpsPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.obstacle.pid.get</name>
		///	<symbol>kSystemObstaclePidGet</symbol>
		///	<scope>system.obstacle.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kPitchProportional">PitchProportional</response>
		///		<response type="int" symbol="kPitchIntegral">PitchIntegral</response>
		///		<response type="int" symbol="kPitchDerivative">PitchDerivative</response>
		///		<response type="int" symbol="kRollProportional">RollProportional</response>
		///		<response type="int" symbol="kRollIntegral">RollIntegral</response>
		///		<response type="int" symbol="kRollDerivative">RollDerivative</response>
		///		<response type="int" symbol="kYawProportional">YawProportional</response>
		///		<response type="int" symbol="kYawIntegral">YawIntegral</response>
		///		<response type="int" symbol="kYawDerivative">YawDerivative</response>
		///	</responses>
		///</command>
		public static void SystemObstaclePidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemObstaclePidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.obstacle.internals.get</name>
		///	<symbol>kSystemObstacleInternalsGet</symbol>
		///	<scope>system.obstacle.internals</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kTopAmbient">TopAmbient</response>
		///		<response type="short" symbol="kTopCt">TopCt</response>
		///		<response type="short" symbol="kTopResult">TopResult</response>
		///		<response type="short" symbol="kLeftAmbient">LeftAmbient</response>
		///		<response type="short" symbol="kLeftCt">LeftCt</response>
		///		<response type="short" symbol="kLeftResult">LeftResult</response>
		///		<response type="short" symbol="kRightAmbient">RightAmbient</response>
		///		<response type="short" symbol="kRightCt">RightCt</response>
		///		<response type="short" symbol="kRightResult">RightResult</response>
		///		<response type="short" symbol="kBackAmbient">BackAmbient</response>
		///		<response type="short" symbol="kBackCt">BackCt</response>
		///		<response type="short" symbol="kBackResult">BackResult</response>
		///		<response type="short" symbol="kFrontAmbient">FrontAmbient</response>
		///		<response type="short" symbol="kFrontCt">FrontCt</response>
		///		<response type="short" symbol="kFrontResult">FrontResult</response>
		///	</responses>
		///</command>
		public static void SystemObstacleInternalsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemObstacleInternalsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.altitude.pid.get</name>
		///	<symbol>kSystemAltitudePidGet</symbol>
		///	<scope>system.altitude.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kP">P</response>
		///		<response type="int" symbol="kI">I</response>
		///		<response type="int" symbol="kD">D</response>
		///	</responses>
		///</command>
		public static void SystemAltitudePidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemAltitudePidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.inertial.pid.get</name>
		///	<symbol>kSystemInertialPidGet</symbol>
		///	<scope>system.inertial.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kPitchProportional">PitchProportional</response>
		///		<response type="int" symbol="kPitchIntegral">PitchIntegral</response>
		///		<response type="int" symbol="kPitchDerivative">PitchDerivative</response>
		///		<response type="int" symbol="kRollProportional">RollProportional</response>
		///		<response type="int" symbol="kRollIntegral">RollIntegral</response>
		///		<response type="int" symbol="kRollDerivative">RollDerivative</response>
		///		<response type="int" symbol="kYawProportional">YawProportional</response>
		///		<response type="int" symbol="kYawIntegral">YawIntegral</response>
		///		<response type="int" symbol="kYawDerivative">YawDerivative</response>
		///	</responses>
		///</command>
		public static void SystemInertialPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemInertialPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.motor.set</name>
		///	<symbol>kSystemMotorSet</symbol>
		///	<scope>system.motor</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kMotor1">Motor1</arg>
		///		<arg type="short" symbol="kMotor2">Motor2</arg>
		///		<arg type="short" symbol="kMotor3">Motor3</arg>
		///		<arg type="short" symbol="kMotor4">Motor4</arg>
		///	</arguments>
		///</command>
		public static void SystemMotorSet(uint handle, short motor1, short motor2, short motor3, short motor4)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemMotorSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMotor1;
				sendFrame.Values[0] = (int) motor1;
				sendFrame.Names[1] = Symbols.kMotor2;
				sendFrame.Values[1] = (int) motor2;
				sendFrame.Names[2] = Symbols.kMotor3;
				sendFrame.Values[2] = (int) motor3;
				sendFrame.Names[3] = Symbols.kMotor4;
				sendFrame.Values[3] = (int) motor4;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.expansion.byte.get</name>
		///	<symbol>kSystemExpansionByteGet</symbol>
		///	<scope>system.expansion.byte</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kLength">Length</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kLength">Length</response>
		///	</responses>
		///	<see>system.expansion.byte.set</see>
		///</command>
		public static void SystemExpansionByteGet(uint handle, byte length)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemExpansionByteGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kLength;
				sendFrame.Values[0] = (int) length;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.expansion.byte.set</name>
		///	<symbol>kSystemExpansionByteSet</symbol>
		///	<scope>system.expansion.byte</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kLength">Length</arg>
		///	</arguments>
		///	<see>system.expansion.byte.get</see>
		///</command>
		public static void SystemExpansionByteSet(uint handle, byte length)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemExpansionByteSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kLength;
				sendFrame.Values[0] = (int) length;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.expansion.config.set</name>
		///	<symbol>kSystemExpansionConfigSet</symbol>
		///	<scope>system.expansion.config</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kSpeed">Speed</arg>
		///	</arguments>
		///</command>
		public static void SystemExpansionConfigSet(uint handle, byte speed)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemExpansionConfigSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kSpeed;
				sendFrame.Values[0] = (int) speed;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.bandwidth.get</name>
		///	<symbol>kSystemBandwidthGet</symbol>
		///	<scope>system.bandwidth</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kValue">Value</response>
		///	</responses>
		///	<see>system.bandwidth.set</see>
		///</command>
		public static void SystemBandwidthGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemBandwidthGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.bandwidth.set</name>
		///	<symbol>kSystemBandwidthSet</symbol>
		///	<scope>system.bandwidth</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>system.bandwidth.get</see>
		///</command>
		public static void SystemBandwidthSet(uint handle, ushort value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemBandwidthSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.lastmessage.get</name>
		///	<symbol>kSystemLastmessageGet</symbol>
		///	<scope>system.lastmessage</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kValue">Value</response>
		///	</responses>
		///</command>
		public static void SystemLastmessageGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemLastmessageGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.debug.set</name>
		///	<symbol>kSystemDebugSet</symbol>
		///	<scope>system.debug</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///		<arg type="short" symbol="kMotor1">Motor1</arg>
		///		<arg type="short" symbol="kMotor2">Motor2</arg>
		///		<arg type="short" symbol="kMotor3">Motor3</arg>
		///		<arg type="short" symbol="kMotor4">Motor4</arg>
		///	</arguments>
		///</command>
		public static void SystemDebugSet(uint handle, byte value, short motor1, short motor2, short motor3, short motor4)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemDebugSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
				sendFrame.Names[1] = Symbols.kMotor1;
				sendFrame.Values[1] = (int) motor1;
				sendFrame.Names[2] = Symbols.kMotor2;
				sendFrame.Values[2] = (int) motor2;
				sendFrame.Names[3] = Symbols.kMotor3;
				sendFrame.Values[3] = (int) motor3;
				sendFrame.Names[4] = Symbols.kMotor4;
				sendFrame.Values[4] = (int) motor4;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.calibratecompass.set</name>
		///	<symbol>kSystemCalibratecompassSet</symbol>
		///	<scope>system.calibratecompass</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///</command>
		public static void SystemCalibratecompassSet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemCalibratecompassSet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.time.get</name>
		///	<symbol>kSystemTimeGet</symbol>
		///	<scope>system.time</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kTime">Time</arg>
		///	</arguments>
		///	<see>system.time.set</see>
		///</command>
		public static void SystemTimeGet(uint handle, uint time)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemTimeGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kTime;
				sendFrame.Values[0] = (int) time;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>system.time.set</name>
		///	<symbol>kSystemTimeSet</symbol>
		///	<scope>system.time</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kTime">Time</arg>
		///	</arguments>
		///	<see>system.time.get</see>
		///</command>
		public static void SystemTimeSet(uint handle, uint time)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kSystemTimeSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kTime;
				sendFrame.Values[0] = (int) time;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.resolution.set</name>
		///	<symbol>kCameraResolutionSet</symbol>
		///	<scope>camera.resolution</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kResolution">Resolution</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.resolution.get</see>
		///</command>
		public static void CameraResolutionSet(uint handle, byte resolution)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraResolutionSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kResolution;
				sendFrame.Values[0] = (int) resolution;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.resolution.get</name>
		///	<symbol>kCameraResolutionGet</symbol>
		///	<scope>camera.resolution</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResolution">Resolution</response>
		///	</responses>
		///	<see>camera.resolution.set</see>
		///</command>
		public static void CameraResolutionGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraResolutionGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.mode.set</name>
		///	<symbol>kCameraModeSet</symbol>
		///	<scope>camera.mode</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kMode">Mode</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.mode.get</see>
		///</command>
		public static void CameraModeSet(uint handle, byte mode)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraModeSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMode;
				sendFrame.Values[0] = (int) mode;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.mode.get</name>
		///	<symbol>kCameraModeGet</symbol>
		///	<scope>camera.mode</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kMode">Mode</response>
		///	</responses>
		///	<see>camera.mode.set</see>
		///</command>
		public static void CameraModeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraModeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.brightness.set</name>
		///	<symbol>kCameraBrightnessSet</symbol>
		///	<scope>camera.brightness</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kBrightness">Brightness</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.brightness.get</see>
		///</command>
		public static void CameraBrightnessSet(uint handle, byte brightness)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraBrightnessSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kBrightness;
				sendFrame.Values[0] = (int) brightness;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.brightness.get</name>
		///	<symbol>kCameraBrightnessGet</symbol>
		///	<scope>camera.brightness</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kBrightness">Brightness</response>
		///	</responses>
		///	<see>camera.brightness.set</see>
		///</command>
		public static void CameraBrightnessGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraBrightnessGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.contrast.set</name>
		///	<symbol>kCameraContrastSet</symbol>
		///	<scope>camera.contrast</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kContrast">Contrast</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.contrast.get</see>
		///</command>
		public static void CameraContrastSet(uint handle, byte contrast)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraContrastSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kContrast;
				sendFrame.Values[0] = (int) contrast;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.contrast.get</name>
		///	<symbol>kCameraContrastGet</symbol>
		///	<scope>camera.contrast</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kContrast">Contrast</response>
		///	</responses>
		///	<see>camera.contrast.set</see>
		///</command>
		public static void CameraContrastGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraContrastGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.saturation.set</name>
		///	<symbol>kCameraSaturationSet</symbol>
		///	<scope>camera.saturation</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kSaturation">Saturation</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.saturation.get</see>
		///</command>
		public static void CameraSaturationSet(uint handle, byte saturation)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraSaturationSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kSaturation;
				sendFrame.Values[0] = (int) saturation;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.saturation.get</name>
		///	<symbol>kCameraSaturationGet</symbol>
		///	<scope>camera.saturation</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kSaturation">Saturation</response>
		///	</responses>
		///	<see>camera.saturation.set</see>
		///</command>
		public static void CameraSaturationGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraSaturationGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.uvadjust.set</name>
		///	<symbol>kCameraUvadjustSet</symbol>
		///	<scope>camera.uvadjust</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.uvadjust.get</see>
		///</command>
		public static void CameraUvadjustSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraUvadjustSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.uvadjust.get</name>
		///	<symbol>kCameraUvadjustGet</symbol>
		///	<scope>camera.uvadjust</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.uvadjust.set</see>
		///</command>
		public static void CameraUvadjustGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraUvadjustGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.hue.set</name>
		///	<symbol>kCameraHueSet</symbol>
		///	<scope>camera.hue</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kHue">Hue</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.hue.get</see>
		///</command>
		public static void CameraHueSet(uint handle, byte hue)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraHueSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kHue;
				sendFrame.Values[0] = (int) hue;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.hue.get</name>
		///	<symbol>kCameraHueGet</symbol>
		///	<scope>camera.hue</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kHue">Hue</response>
		///	</responses>
		///	<see>camera.hue.set</see>
		///</command>
		public static void CameraHueGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraHueGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.mirrorflip.set</name>
		///	<symbol>kCameraMirrorflipSet</symbol>
		///	<scope>camera.mirrorflip</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.mirrorflip.get</see>
		///</command>
		public static void CameraMirrorflipSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraMirrorflipSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.mirrorflip.get</name>
		///	<symbol>kCameraMirrorflipGet</symbol>
		///	<scope>camera.mirrorflip</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.mirrorflip.set</see>
		///</command>
		public static void CameraMirrorflipGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraMirrorflipGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.specialeffects.set</name>
		///	<symbol>kCameraSpecialeffectsSet</symbol>
		///	<scope>camera.specialeffects</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.specialeffects.get</see>
		///</command>
		public static void CameraSpecialeffectsSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraSpecialeffectsSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.specialeffects.get</name>
		///	<symbol>kCameraSpecialeffectsGet</symbol>
		///	<scope>camera.specialeffects</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.specialeffects.set</see>
		///</command>
		public static void CameraSpecialeffectsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraSpecialeffectsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.window.set</name>
		///	<symbol>kCameraWindowSet</symbol>
		///	<scope>camera.window</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kX">X</arg>
		///		<arg type="ushort" symbol="kY">Y</arg>
		///		<arg type="ushort" symbol="kWidth">Width</arg>
		///	</arguments>
		///	<see>camera.window.get</see>
		///</command>
		public static void CameraWindowSet(uint handle, ushort x, ushort y, ushort width)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraWindowSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kX;
				sendFrame.Values[0] = (int) x;
				sendFrame.Names[1] = Symbols.kY;
				sendFrame.Values[1] = (int) y;
				sendFrame.Names[2] = Symbols.kWidth;
				sendFrame.Values[2] = (int) width;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.window.get</name>
		///	<symbol>kCameraWindowGet</symbol>
		///	<scope>camera.window</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kX">X</response>
		///		<response type="ushort" symbol="kY">Y</response>
		///		<response type="ushort" symbol="kWidth">Width</response>
		///	</responses>
		///	<see>camera.window.set</see>
		///</command>
		public static void CameraWindowGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraWindowGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.stream.start</name>
		///	<symbol>kCameraStreamStart</symbol>
		///	<scope>camera.stream</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>camera.stream.stop</see>
		///</command>
		public static void CameraStreamStart(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraStreamStart;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.stream.stop</name>
		///	<symbol>kCameraStreamStop</symbol>
		///	<scope>camera.stream</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<see>camera.stream.start</see>
		///</command>
		public static void CameraStreamStop(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraStreamStop;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.photo.get</name>
		///	<symbol>kCameraPhotoGet</symbol>
		///	<scope>camera.photo</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///</command>
		public static void CameraPhotoGet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraPhotoGet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.tilt.set</name>
		///	<symbol>kCameraTiltSet</symbol>
		///	<scope>camera.tilt</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>camera.tilt.get</see>
		///</command>
		public static void CameraTiltSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraTiltSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.tilt.get</name>
		///	<symbol>kCameraTiltGet</symbol>
		///	<scope>camera.tilt</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.tilt.set</see>
		///</command>
		public static void CameraTiltGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraTiltGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.fps.set</name>
		///	<symbol>kCameraFpsSet</symbol>
		///	<scope>camera.fps</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>camera.fps.get</see>
		///</command>
		public static void CameraFpsSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraFpsSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.fps.get</name>
		///	<symbol>kCameraFpsGet</symbol>
		///	<scope>camera.fps</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.fps.set</see>
		///</command>
		public static void CameraFpsGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraFpsGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.video.resolution.set</name>
		///	<symbol>kCameraVideoResolutionSet</symbol>
		///	<scope>camera.video.resolution</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>camera.video.resolution.get</see>
		///</command>
		public static void CameraVideoResolutionSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraVideoResolutionSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.video.resolution.get</name>
		///	<symbol>kCameraVideoResolutionGet</symbol>
		///	<scope>camera.video.resolution</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.video.resolution.set</see>
		///</command>
		public static void CameraVideoResolutionGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraVideoResolutionGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.video.keyframe.get</name>
		///	<symbol>kCameraVideoKeyframeGet</symbol>
		///	<scope>camera.video.keyframe</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///</command>
		public static void CameraVideoKeyframeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraVideoKeyframeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.control.set</name>
		///	<symbol>kCameraAgcExposureControlSet</symbol>
		///	<scope>camera.agc.exposure.control</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.agc.exposure.control.get</see>
		///</command>
		public static void CameraAgcExposureControlSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureControlSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.control.get</name>
		///	<symbol>kCameraAgcExposureControlGet</symbol>
		///	<scope>camera.agc.exposure.control</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.agc.exposure.control.set</see>
		///</command>
		public static void CameraAgcExposureControlGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureControlGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.weight.set</name>
		///	<symbol>kCameraAgcExposureWeightSet</symbol>
		///	<scope>camera.agc.exposure.weight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.agc.exposure.weight.get</see>
		///</command>
		public static void CameraAgcExposureWeightSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureWeightSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.weight.get</name>
		///	<symbol>kCameraAgcExposureWeightGet</symbol>
		///	<scope>camera.agc.exposure.weight</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.agc.exposure.weight.set</see>
		///</command>
		public static void CameraAgcExposureWeightGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureWeightGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.set</name>
		///	<symbol>kCameraAgcExposureSet</symbol>
		///	<scope>camera.agc.exposure</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.agc.exposure.get</see>
		///</command>
		public static void CameraAgcExposureSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.exposure.get</name>
		///	<symbol>kCameraAgcExposureGet</symbol>
		///	<scope>camera.agc.exposure</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.agc.exposure.set</see>
		///</command>
		public static void CameraAgcExposureGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcExposureGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.evlevel.set</name>
		///	<symbol>kCameraAgcEvlevelSet</symbol>
		///	<scope>camera.agc.evlevel</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.agc.evlevel.get</see>
		///</command>
		public static void CameraAgcEvlevelSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcEvlevelSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.agc.evlevel.get</name>
		///	<symbol>kCameraAgcEvlevelGet</symbol>
		///	<scope>camera.agc.evlevel</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.agc.evlevel.set</see>
		///</command>
		public static void CameraAgcEvlevelGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraAgcEvlevelGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.lenc.set</name>
		///	<symbol>kCameraImageprocessingLencSet</symbol>
		///	<scope>camera.imageprocessing.lenc</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.imageprocessing.lenc.get</see>
		///</command>
		public static void CameraImageprocessingLencSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingLencSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.lenc.get</name>
		///	<symbol>kCameraImageprocessingLencGet</symbol>
		///	<scope>camera.imageprocessing.lenc</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.imageprocessing.lenc.set</see>
		///</command>
		public static void CameraImageprocessingLencGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingLencGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.pixelcorrection.set</name>
		///	<symbol>kCameraImageprocessingPixelcorrectionSet</symbol>
		///	<scope>camera.imageprocessing.pixelcorrection</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.imageprocessing.pixelcorrection.get</see>
		///</command>
		public static void CameraImageprocessingPixelcorrectionSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingPixelcorrectionSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.pixelcorrection.get</name>
		///	<symbol>kCameraImageprocessingPixelcorrectionGet</symbol>
		///	<scope>camera.imageprocessing.pixelcorrection</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.imageprocessing.pixelcorrection.set</see>
		///</command>
		public static void CameraImageprocessingPixelcorrectionGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingPixelcorrectionGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.sharpness.set</name>
		///	<symbol>kCameraImageprocessingSharpnessSet</symbol>
		///	<scope>camera.imageprocessing.sharpness</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.imageprocessing.sharpness.get</see>
		///</command>
		public static void CameraImageprocessingSharpnessSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingSharpnessSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.sharpness.get</name>
		///	<symbol>kCameraImageprocessingSharpnessGet</symbol>
		///	<scope>camera.imageprocessing.sharpness</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.imageprocessing.sharpness.set</see>
		///</command>
		public static void CameraImageprocessingSharpnessGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingSharpnessGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.denoise.set</name>
		///	<symbol>kCameraImageprocessingDenoiseSet</symbol>
		///	<scope>camera.imageprocessing.denoise</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kValue">Value</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.imageprocessing.denoise.get</see>
		///</command>
		public static void CameraImageprocessingDenoiseSet(uint handle, byte value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingDenoiseSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.imageprocessing.denoise.get</name>
		///	<symbol>kCameraImageprocessingDenoiseGet</symbol>
		///	<scope>camera.imageprocessing.denoise</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kValue">Value</response>
		///	</responses>
		///	<see>camera.imageprocessing.denoise.set</see>
		///</command>
		public static void CameraImageprocessingDenoiseGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraImageprocessingDenoiseGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.bandingfilter.set</name>
		///	<symbol>kCameraBandingfilterSet</symbol>
		///	<scope>camera.bandingfilter</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kFilter">Filter</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kResult">Result</response>
		///	</responses>
		///	<see>camera.bandingfilter.get</see>
		///</command>
		public static void CameraBandingfilterSet(uint handle, byte filter)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraBandingfilterSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kFilter;
				sendFrame.Values[0] = (int) filter;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.bandingfilter.get</name>
		///	<symbol>kCameraBandingfilterGet</symbol>
		///	<scope>camera.bandingfilter</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kFilter">Filter</response>
		///	</responses>
		///	<see>camera.bandingfilter.set</see>
		///</command>
		public static void CameraBandingfilterGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraBandingfilterGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.stabilise.set</name>
		///	<symbol>kCameraStabiliseSet</symbol>
		///	<scope>camera.stabilise</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kFlag">Flag</arg>
		///	</arguments>
		///	<see>camera.stabilise.get</see>
		///</command>
		public static void CameraStabiliseSet(uint handle, uint flag)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraStabiliseSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kFlag;
				sendFrame.Values[0] = (int) flag;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>camera.stabilise.get</name>
		///	<symbol>kCameraStabiliseGet</symbol>
		///	<scope>camera.stabilise</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kFlag">Flag</response>
		///	</responses>
		///	<see>camera.stabilise.set</see>
		///</command>
		public static void CameraStabiliseGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kCameraStabiliseGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.pitchroll.pid.set</name>
		///	<symbol>kConfigPitchrollPidSet</symbol>
		///	<scope>config.pitchroll.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.pitchroll.pid.get</see>
		///</command>
		public static void ConfigPitchrollPidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigPitchrollPidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.pitchroll.pid.get</name>
		///	<symbol>kConfigPitchrollPidGet</symbol>
		///	<scope>config.pitchroll.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.pitchroll.pid.set</see>
		///</command>
		public static void ConfigPitchrollPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigPitchrollPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.altitude.pid.set</name>
		///	<symbol>kConfigAltitudePidSet</symbol>
		///	<scope>config.altitude.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.altitude.pid.get</see>
		///</command>
		public static void ConfigAltitudePidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigAltitudePidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.altitude.pid.get</name>
		///	<symbol>kConfigAltitudePidGet</symbol>
		///	<scope>config.altitude.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.altitude.pid.set</see>
		///</command>
		public static void ConfigAltitudePidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigAltitudePidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.yaw.pid.set</name>
		///	<symbol>kConfigYawPidSet</symbol>
		///	<scope>config.yaw.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.yaw.pid.get</see>
		///</command>
		public static void ConfigYawPidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigYawPidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.yaw.pid.get</name>
		///	<symbol>kConfigYawPidGet</symbol>
		///	<scope>config.yaw.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.yaw.pid.set</see>
		///</command>
		public static void ConfigYawPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigYawPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.obstacle.pid.set</name>
		///	<symbol>kConfigObstaclePidSet</symbol>
		///	<scope>config.obstacle.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.obstacle.pid.get</see>
		///</command>
		public static void ConfigObstaclePidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigObstaclePidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.obstacle.pid.get</name>
		///	<symbol>kConfigObstaclePidGet</symbol>
		///	<scope>config.obstacle.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.obstacle.pid.set</see>
		///</command>
		public static void ConfigObstaclePidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigObstaclePidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gps.pid.set</name>
		///	<symbol>kConfigGpsPidSet</symbol>
		///	<scope>config.gps.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.gps.pid.get</see>
		///</command>
		public static void ConfigGpsPidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGpsPidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gps.pid.get</name>
		///	<symbol>kConfigGpsPidGet</symbol>
		///	<scope>config.gps.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.gps.pid.set</see>
		///</command>
		public static void ConfigGpsPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGpsPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gps.enable.get</name>
		///	<symbol>kConfigGpsEnableGet</symbol>
		///	<scope>config.gps.enable</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kPosition">Position</response>
		///		<response type="byte" symbol="kSpeed">Speed</response>
		///		<response type="ushort" symbol="kSensitivity">Sensitivity</response>
		///	</responses>
		///	<see>config.gps.enable.set</see>
		///</command>
		public static void ConfigGpsEnableGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGpsEnableGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gps.enable.set</name>
		///	<symbol>kConfigGpsEnableSet</symbol>
		///	<scope>config.gps.enable</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kPosition">Position</arg>
		///		<arg type="byte" symbol="kSpeed">Speed</arg>
		///		<arg type="ushort" symbol="kSensitivity">Sensitivity</arg>
		///	</arguments>
		///	<see>config.gps.enable.get</see>
		///</command>
		public static void ConfigGpsEnableSet(uint handle, byte position, byte speed, ushort sensitivity)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGpsEnableSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kPosition;
				sendFrame.Values[0] = (int) position;
				sendFrame.Names[1] = Symbols.kSpeed;
				sendFrame.Values[1] = (int) speed;
				sendFrame.Names[2] = Symbols.kSensitivity;
				sendFrame.Values[2] = (int) sensitivity;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.inertial.pid.set</name>
		///	<symbol>kConfigInertialPidSet</symbol>
		///	<scope>config.inertial.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kProportional">Proportional</arg>
		///		<arg type="uint" symbol="kProportionalClamp">ProportionalClamp</arg>
		///		<arg type="uint" symbol="kIntegral">Integral</arg>
		///		<arg type="uint" symbol="kIntegralClamp">IntegralClamp</arg>
		///		<arg type="uint" symbol="kDerivative">Derivative</arg>
		///		<arg type="uint" symbol="kDerivativeClamp">DerivativeClamp</arg>
		///	</arguments>
		///	<see>config.inertial.pid.get</see>
		///</command>
		public static void ConfigInertialPidSet(uint handle, uint proportional, uint proportionalclamp, uint integral, uint integralclamp, uint derivative, uint derivativeclamp)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigInertialPidSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kProportional;
				sendFrame.Values[0] = (int) proportional;
				sendFrame.Names[1] = Symbols.kProportionalClamp;
				sendFrame.Values[1] = (int) proportionalclamp;
				sendFrame.Names[2] = Symbols.kIntegral;
				sendFrame.Values[2] = (int) integral;
				sendFrame.Names[3] = Symbols.kIntegralClamp;
				sendFrame.Values[3] = (int) integralclamp;
				sendFrame.Names[4] = Symbols.kDerivative;
				sendFrame.Values[4] = (int) derivative;
				sendFrame.Names[5] = Symbols.kDerivativeClamp;
				sendFrame.Values[5] = (int) derivativeclamp;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.inertial.pid.get</name>
		///	<symbol>kConfigInertialPidGet</symbol>
		///	<scope>config.inertial.pid</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="uint" symbol="kProportional">Proportional</response>
		///		<response type="uint" symbol="kProportionalClamp">ProportionalClamp</response>
		///		<response type="uint" symbol="kIntegral">Integral</response>
		///		<response type="uint" symbol="kIntegralClamp">IntegralClamp</response>
		///		<response type="uint" symbol="kDerivative">Derivative</response>
		///		<response type="uint" symbol="kDerivativeClamp">DerivativeClamp</response>
		///	</responses>
		///	<see>config.inertial.pid.set</see>
		///</command>
		public static void ConfigInertialPidGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigInertialPidGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.mag.offset.set</name>
		///	<symbol>kConfigMagOffsetSet</symbol>
		///	<scope>config.mag.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kX">X</arg>
		///		<arg type="short" symbol="kY">Y</arg>
		///		<arg type="short" symbol="kZ">Z</arg>
		///	</arguments>
		///	<see>config.mag.offset.get</see>
		///</command>
		public static void ConfigMagOffsetSet(uint handle, short x, short y, short z)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMagOffsetSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kX;
				sendFrame.Values[0] = (int) x;
				sendFrame.Names[1] = Symbols.kY;
				sendFrame.Values[1] = (int) y;
				sendFrame.Names[2] = Symbols.kZ;
				sendFrame.Values[2] = (int) z;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.mag.offset.get</name>
		///	<symbol>kConfigMagOffsetGet</symbol>
		///	<scope>config.mag.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///	</responses>
		///	<see>config.mag.offset.set</see>
		///</command>
		public static void ConfigMagOffsetGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMagOffsetGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.mag.range.get</name>
		///	<symbol>kConfigMagRangeGet</symbol>
		///	<scope>config.mag.range</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="int" symbol="kXMax">XMax</response>
		///		<response type="int" symbol="kYMax">YMax</response>
		///		<response type="int" symbol="kZMax">ZMax</response>
		///		<response type="int" symbol="kXMin">XMin</response>
		///		<response type="int" symbol="kYMin">YMin</response>
		///		<response type="int" symbol="kZMin">ZMin</response>
		///		<response type="int" symbol="kXM">XM</response>
		///		<response type="int" symbol="kYM">YM</response>
		///		<response type="int" symbol="kZM">ZM</response>
		///	</responses>
		///</command>
		public static void ConfigMagRangeGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMagRangeGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.mag.true.get</name>
		///	<symbol>kConfigMagTrueGet</symbol>
		///	<scope>config.mag.true</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kAngle">Angle</response>
		///	</responses>
		///	<see>config.mag.true.set</see>
		///</command>
		public static void ConfigMagTrueGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMagTrueGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.mag.true.set</name>
		///	<symbol>kConfigMagTrueSet</symbol>
		///	<scope>config.mag.true</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kAngle">Angle</arg>
		///	</arguments>
		///	<see>config.mag.true.get</see>
		///</command>
		public static void ConfigMagTrueSet(uint handle, short angle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMagTrueSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kAngle;
				sendFrame.Values[0] = (int) angle;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.accel.offset.set</name>
		///	<symbol>kConfigAccelOffsetSet</symbol>
		///	<scope>config.accel.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kX">X</arg>
		///		<arg type="short" symbol="kY">Y</arg>
		///		<arg type="short" symbol="kZ">Z</arg>
		///		<arg type="short" symbol="kXmin">Xmin</arg>
		///		<arg type="short" symbol="kYmin">Ymin</arg>
		///		<arg type="short" symbol="kZmin">Zmin</arg>
		///		<arg type="short" symbol="kXmax">Xmax</arg>
		///		<arg type="short" symbol="kYmax">Ymax</arg>
		///		<arg type="short" symbol="kZmax">Zmax</arg>
		///	</arguments>
		///	<see>config.accel.offset.get</see>
		///</command>
		public static void ConfigAccelOffsetSet(uint handle, short x, short y, short z, short xmin, short ymin, short zmin, short xmax, short ymax, short zmax)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigAccelOffsetSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kX;
				sendFrame.Values[0] = (int) x;
				sendFrame.Names[1] = Symbols.kY;
				sendFrame.Values[1] = (int) y;
				sendFrame.Names[2] = Symbols.kZ;
				sendFrame.Values[2] = (int) z;
				sendFrame.Names[3] = Symbols.kXmin;
				sendFrame.Values[3] = (int) xmin;
				sendFrame.Names[4] = Symbols.kYmin;
				sendFrame.Values[4] = (int) ymin;
				sendFrame.Names[5] = Symbols.kZmin;
				sendFrame.Values[5] = (int) zmin;
				sendFrame.Names[6] = Symbols.kXmax;
				sendFrame.Values[6] = (int) xmax;
				sendFrame.Names[7] = Symbols.kYmax;
				sendFrame.Values[7] = (int) ymax;
				sendFrame.Names[8] = Symbols.kZmax;
				sendFrame.Values[8] = (int) zmax;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.accel.offset.get</name>
		///	<symbol>kConfigAccelOffsetGet</symbol>
		///	<scope>config.accel.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="short" symbol="kZ">Z</response>
		///		<response type="short" symbol="kXmin">Xmin</response>
		///		<response type="short" symbol="kYmin">Ymin</response>
		///		<response type="short" symbol="kZmin">Zmin</response>
		///		<response type="short" symbol="kXmax">Xmax</response>
		///		<response type="short" symbol="kYmax">Ymax</response>
		///		<response type="short" symbol="kZmax">Zmax</response>
		///	</responses>
		///	<see>config.accel.offset.set</see>
		///</command>
		public static void ConfigAccelOffsetGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigAccelOffsetGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gyro.offset.set</name>
		///	<symbol>kConfigGyroOffsetSet</symbol>
		///	<scope>config.gyro.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kX">X</arg>
		///		<arg type="short" symbol="kY">Y</arg>
		///		<arg type="int" symbol="kZ">Z</arg>
		///	</arguments>
		///	<see>config.gyro.offset.get</see>
		///</command>
		public static void ConfigGyroOffsetSet(uint handle, short x, short y, int z)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGyroOffsetSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kX;
				sendFrame.Values[0] = (int) x;
				sendFrame.Names[1] = Symbols.kY;
				sendFrame.Values[1] = (int) y;
				sendFrame.Names[2] = Symbols.kZ;
				sendFrame.Values[2] = (int) z;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.gyro.offset.get</name>
		///	<symbol>kConfigGyroOffsetGet</symbol>
		///	<scope>config.gyro.offset</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kX">X</response>
		///		<response type="short" symbol="kY">Y</response>
		///		<response type="int" symbol="kZ">Z</response>
		///	</responses>
		///	<see>config.gyro.offset.set</see>
		///</command>
		public static void ConfigGyroOffsetGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigGyroOffsetGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.degreeratio.set</name>
		///	<symbol>kConfigDegreeratioSet</symbol>
		///	<scope>config.degreeratio</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>config.degreeratio.get</see>
		///</command>
		public static void ConfigDegreeratioSet(uint handle, ushort value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigDegreeratioSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.degreeratio.get</name>
		///	<symbol>kConfigDegreeratioGet</symbol>
		///	<scope>config.degreeratio</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kValue">Value</response>
		///	</responses>
		///	<see>config.degreeratio.set</see>
		///</command>
		public static void ConfigDegreeratioGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigDegreeratioGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.pitchrollyaw.trim.set</name>
		///	<symbol>kConfigPitchrollyawTrimSet</symbol>
		///	<scope>config.pitchrollyaw.trim</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kPitch">Pitch</arg>
		///		<arg type="short" symbol="kRoll">Roll</arg>
		///		<arg type="short" symbol="kYaw">Yaw</arg>
		///	</arguments>
		///	<see>config.pitchrollyaw.trim.get</see>
		///</command>
		public static void ConfigPitchrollyawTrimSet(uint handle, short pitch, short roll, short yaw)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigPitchrollyawTrimSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kPitch;
				sendFrame.Values[0] = (int) pitch;
				sendFrame.Names[1] = Symbols.kRoll;
				sendFrame.Values[1] = (int) roll;
				sendFrame.Names[2] = Symbols.kYaw;
				sendFrame.Values[2] = (int) yaw;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.pitchrollyaw.trim.get</name>
		///	<symbol>kConfigPitchrollyawTrimGet</symbol>
		///	<scope>config.pitchrollyaw.trim</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kPitch">Pitch</response>
		///		<response type="short" symbol="kRoll">Roll</response>
		///		<response type="short" symbol="kYaw">Yaw</response>
		///	</responses>
		///	<see>config.pitchrollyaw.trim.set</see>
		///</command>
		public static void ConfigPitchrollyawTrimGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigPitchrollyawTrimGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.oneg.set</name>
		///	<symbol>kConfigOnegSet</symbol>
		///	<scope>config.oneg</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="short" symbol="kValue">Value</arg>
		///	</arguments>
		///	<see>config.oneg.get</see>
		///</command>
		public static void ConfigOnegSet(uint handle, short value)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigOnegSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kValue;
				sendFrame.Values[0] = (int) value;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.oneg.get</name>
		///	<symbol>kConfigOnegGet</symbol>
		///	<scope>config.oneg</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="short" symbol="kValue">Value</response>
		///	</responses>
		///	<see>config.oneg.set</see>
		///</command>
		public static void ConfigOnegGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigOnegGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.ir.filter.set</name>
		///	<symbol>kConfigIrFilterSet</symbol>
		///	<scope>config.ir.filter</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kAmbient">Ambient</arg>
		///		<arg type="ushort" symbol="kCrosstalk">Crosstalk</arg>
		///		<arg type="ushort" symbol="kResult">Result</arg>
		///		<arg type="ushort" symbol="kDistance">Distance</arg>
		///	</arguments>
		///	<see>config.ir.filter.get</see>
		///</command>
		public static void ConfigIrFilterSet(uint handle, ushort ambient, ushort crosstalk, ushort result, ushort distance)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigIrFilterSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kAmbient;
				sendFrame.Values[0] = (int) ambient;
				sendFrame.Names[1] = Symbols.kCrosstalk;
				sendFrame.Values[1] = (int) crosstalk;
				sendFrame.Names[2] = Symbols.kResult;
				sendFrame.Values[2] = (int) result;
				sendFrame.Names[3] = Symbols.kDistance;
				sendFrame.Values[3] = (int) distance;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.ir.filter.get</name>
		///	<symbol>kConfigIrFilterGet</symbol>
		///	<scope>config.ir.filter</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kAmbient">Ambient</response>
		///		<response type="ushort" symbol="kCrosstalk">Crosstalk</response>
		///		<response type="ushort" symbol="kResult">Result</response>
		///		<response type="ushort" symbol="kDistance">Distance</response>
		///	</responses>
		///	<see>config.ir.filter.set</see>
		///</command>
		public static void ConfigIrFilterGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigIrFilterGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.integration.set</name>
		///	<symbol>kConfigIntegrationSet</symbol>
		///	<scope>config.integration</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kDepth">Depth</arg>
		///	</arguments>
		///	<see>config.integration.get</see>
		///</command>
		public static void ConfigIntegrationSet(uint handle, ushort depth)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigIntegrationSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kDepth;
				sendFrame.Values[0] = (int) depth;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.integration.get</name>
		///	<symbol>kConfigIntegrationGet</symbol>
		///	<scope>config.integration</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kDepth">Depth</response>
		///	</responses>
		///	<see>config.integration.set</see>
		///</command>
		public static void ConfigIntegrationGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigIntegrationGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.noactivity.limit.set</name>
		///	<symbol>kConfigNoactivityLimitSet</symbol>
		///	<scope>config.noactivity.limit</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kMs">Ms</arg>
		///	</arguments>
		///	<see>config.noactivity.limit.get</see>
		///</command>
		public static void ConfigNoactivityLimitSet(uint handle, ushort ms)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigNoactivityLimitSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMs;
				sendFrame.Values[0] = (int) ms;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.noactivity.limit.get</name>
		///	<symbol>kConfigNoactivityLimitGet</symbol>
		///	<scope>config.noactivity.limit</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kTime">Time</response>
		///	</responses>
		///	<see>config.noactivity.limit.set</see>
		///</command>
		public static void ConfigNoactivityLimitGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigNoactivityLimitGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.lostlink.limit.set</name>
		///	<symbol>kConfigLostlinkLimitSet</symbol>
		///	<scope>config.lostlink.limit</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kMs">Ms</arg>
		///	</arguments>
		///	<see>config.lostlink.limit.get</see>
		///</command>
		public static void ConfigLostlinkLimitSet(uint handle, ushort ms)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigLostlinkLimitSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMs;
				sendFrame.Values[0] = (int) ms;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.lostlink.limit.get</name>
		///	<symbol>kConfigLostlinkLimitGet</symbol>
		///	<scope>config.lostlink.limit</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kTime">Time</response>
		///	</responses>
		///	<see>config.lostlink.limit.set</see>
		///</command>
		public static void ConfigLostlinkLimitGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigLostlinkLimitGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.minsat.set</name>
		///	<symbol>kConfigMinsatSet</symbol>
		///	<scope>config.minsat</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kMs">Ms</arg>
		///	</arguments>
		///	<see>config.minsat.get</see>
		///</command>
		public static void ConfigMinsatSet(uint handle, ushort ms)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMinsatSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kMs;
				sendFrame.Values[0] = (int) ms;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.minsat.get</name>
		///	<symbol>kConfigMinsatGet</symbol>
		///	<scope>config.minsat</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="ushort" symbol="kTime">Time</response>
		///	</responses>
		///	<see>config.minsat.set</see>
		///</command>
		public static void ConfigMinsatGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigMinsatGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.camera.set</name>
		///	<symbol>kConfigCameraSet</symbol>
		///	<scope>config.camera</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="uint" symbol="kSettings">Settings</arg>
		///	</arguments>
		///</command>
		public static void ConfigCameraSet(uint handle, uint settings)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigCameraSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kSettings;
				sendFrame.Values[0] = (int) settings;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.sonar.set</name>
		///	<symbol>kConfigSonarSet</symbol>
		///	<scope>config.sonar</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="ushort" symbol="kThreshold">Threshold</arg>
		///		<arg type="byte" symbol="kAmbientFilter">AmbientFilter</arg>
		///		<arg type="byte" symbol="kActiveFilter">ActiveFilter</arg>
		///		<arg type="byte" symbol="kFilterAway">FilterAway</arg>
		///		<arg type="byte" symbol="kFilterCloser">FilterCloser</arg>
		///		<arg type="ushort" symbol="kAltitudeDeltaThreshold">AltitudeDeltaThreshold</arg>
		///	</arguments>
		///</command>
		public static void ConfigSonarSet(uint handle, ushort threshold, byte ambientfilter, byte activefilter, byte filteraway, byte filtercloser, ushort altitudedeltathreshold)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigSonarSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kThreshold;
				sendFrame.Values[0] = (int) threshold;
				sendFrame.Names[1] = Symbols.kAmbientFilter;
				sendFrame.Values[1] = (int) ambientfilter;
				sendFrame.Names[2] = Symbols.kActiveFilter;
				sendFrame.Values[2] = (int) activefilter;
				sendFrame.Names[3] = Symbols.kFilterAway;
				sendFrame.Values[3] = (int) filteraway;
				sendFrame.Names[4] = Symbols.kFilterCloser;
				sendFrame.Values[4] = (int) filtercloser;
				sendFrame.Names[5] = Symbols.kAltitudeDeltaThreshold;
				sendFrame.Values[5] = (int) altitudedeltathreshold;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.obstacleavoidance.enable.get</name>
		///	<symbol>kConfigObstacleavoidanceEnableGet</symbol>
		///	<scope>config.obstacleavoidance.enable</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kDistance">Distance</response>
		///		<response type="byte" symbol="kSpeed">Speed</response>
		///		<response type="ushort" symbol="kSensitivity">Sensitivity</response>
		///	</responses>
		///	<see>config.obstacleavoidance.enable.set</see>
		///</command>
		public static void ConfigObstacleavoidanceEnableGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigObstacleavoidanceEnableGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.obstacleavoidance.enable.set</name>
		///	<symbol>kConfigObstacleavoidanceEnableSet</symbol>
		///	<scope>config.obstacleavoidance.enable</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///		<arg type="byte" symbol="kDistance">Distance</arg>
		///		<arg type="byte" symbol="kSpeed">Speed</arg>
		///		<arg type="ushort" symbol="kSensitivity">Sensitivity</arg>
		///	</arguments>
		///	<see>config.obstacleavoidance.enable.get</see>
		///</command>
		public static void ConfigObstacleavoidanceEnableSet(uint handle, byte distance, byte speed, ushort sensitivity)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigObstacleavoidanceEnableSet;
			sendFrame.Type = Frame.kSendFrame;
			unchecked
			{
				sendFrame.Names[0] = Symbols.kDistance;
				sendFrame.Values[0] = (int) distance;
				sendFrame.Names[1] = Symbols.kSpeed;
				sendFrame.Values[1] = (int) speed;
				sendFrame.Names[2] = Symbols.kSensitivity;
				sendFrame.Values[2] = (int) sensitivity;
			}
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.compass.enable.get</name>
		///	<symbol>kConfigCompassEnableGet</symbol>
		///	<scope>config.compass.enable</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///	<responses>
		///		<response type="byte" symbol="kFlag">Flag</response>
		///	</responses>
		///</command>
		public static void ConfigCompassEnableGet(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigCompassEnableGet;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}

		///<command>
		///	<name>config.save</name>
		///	<symbol>kConfigSave</symbol>
		///	<scope>config</scope>
		///	<arguments>
		///		<arg type="uint">Drone Handle</arg>
		///	</arguments>
		///</command>
		public static void ConfigSave(uint handle)
		{
			Frame sendFrame = new Frame(handle);
			sendFrame.Reference = Symbols.kConfigSave;
			sendFrame.Type = Frame.kSendFrame;
			Library.Send(ref sendFrame);
		}
	}
}
