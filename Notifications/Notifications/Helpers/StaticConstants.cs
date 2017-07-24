// StaticConstants.cs
//
//  Author:
//       Dattatraya Pawar <dpawar@slb.com>
//
//  Copyright (c) 2017 Schlumberger Technology Corporatiion
using System;
using System.Collections.Generic;

namespace Notifications.Helpers
{
	public class StaticConstants
	{
		#region Navigation State
		public const int UP_NAVSTATE = 0;
		public const int DOWN_NAVSTATE = 1;
		#endregion

		#region View State
		public const int EARNING_VIEWSTATE = 0;
		public const int CASH_VIEWSTATE = 1;
		#endregion

		#region Local State Markers
		// subsegment all -- LOCAL only
		public static int SUBSEGMENT_ALL = 3;
		//HierarchyType ID's  -- LOCAL only
		public const int HIERARCHY_AREA = 0;
		public const int HIERARCHY_GMK = 1;
		public const int HIERARCHY_BU = 2;
		#endregion

		#region Services
		public const int SERVICE_REQUEST_F0 = 0;
		public const int SERVICE_REQUEST_F1 = 1;
		public const int SERVICE_REQUEST_F2 = 2;
		public const string NETWORK_ERROR_TITLE = "Network error";
		public const string NETWORK_ERROR_MESSAGE = "Unable to load the data";
		public const string USERDETAILS_ERROR_MESSAGE = "Unable to fetch user alias";
		public const string OK_BUTTON_TITLE = "OK";
		public const string CANCEL_BUTTON_TITLE = "Cancel";
		public const string SERVER_ERROR = "Something went wrong";
		public const string SERVER_UNAVAILABLE_ERROR = "No internet connection or can not reach the server, please try again";
		#endregion

		#region Analytics
		public static string AN_NETWORK = "NETWORK";
		public static string AN_GET = "GET";
		public static string AN_POST = "POST";
		public static string AN_MOBILE_IRON = "MOBILE_IRON";
		public static string AN_TIME_TRACK = "TIME_TRACK";

		public static string AN_MAPS = "MAPS_AND_RULES";
		public static string AN_FINANCIAL = "FINANCIAL_DETAILS";
		public static string AN_JOBM = "JOBM_DETAILS";

		public static string AN_LOGIN = "USER_LOGIN";
		public static string AN_CONFIGS = "MI_CONFIG";
		#endregion

		#region Messaging Strings
		#endregion Messaging Strings	

		#region Image Assets
		public const string SETTINGS_BUTTON_IMAGE = "Setting.png";
		public const string BACK_BUTTON_AREAS_IMAGE = "Areas_Back.png";
		public const string BACK_BUTTON_GMKS_IMAGE = "Gmks_Back.png";
		public const string NEXT_BUTTON_WHITE_IMAGE = "Arrow_Next_White.png";
		public const string NEXT_BUTTON_GRAY_IMAGE = "Arrow_Next.png";
		public const string DASHBOARD_PLACEHOLDER_IMAGE = "Loading_Placeholder.png";
		public const string DASHBOARD_BADGE_IMAGE = "Badge.png";
		public const string TAP_DIRECTION_PLUS_IMAGE = "Plus_Tab.png";
		public const string TAP_DIRECTION_MINUS_IMAGE = "Minus_Tab.png";
		public const string RADIO_BUTTON_ACTIVE_IMAGE = "RadioButton_Selected.png";
		public const string RADIO_BUTTON_DEACTIVE_IMAGE = "RadioButton_Normal.png";
		#endregion Image Assets

		#region SLB Hex Colors
		public const long SLB_NAVY = 0xFF003366;
		public const long SLB_GRAY = 0xFF99999;
		public const long SLB_LT_GRAY = 0xFFE6E8EC;
		public const long SLB_MED_GRAY = 0xFFD8DCDE;
		public const long SLB_DK_GRAY = 0xFF898989;
		public const long SLB_STEEL = 0xFF9AACC0;   // bar background
		public const long SLB_GREEN = 0xFF34C04E;   // revenue main color
		public const long SLB_BLUE = 0xFF2C97DA;    // expense main color
		public const long SLB_LT_BLUE = 0xFFB5DDFF;
		public const long SLB_PURPLE = 0xFF514D85;
		public const long SLB_RED = 0xFFF54336;
		public const long SLB_ORANGE = 0xFFF6871F;
		public const long SLB_YELLOW = 0xFFF6B597;
		public const long SLB_TEAL = 0xFF138C7F;
		public const long SLB_AQUA = 0xFF2D96AD;
		public const long SLB_BLACK = 0xFF6F757B;
        public const long SLB_BLACK_FADED = 0xFFB7B4B4;

		public const long NAVIGATION_BACKGROUND = 0xFF2D343D;
		public const long SEGMENTED_CONTROL_BORDER = 0xFFE6E8EC;

		//Tile Colours
		public const long TILE_CM_DEFAULT_VALUE = 0xFF2D343D;
		public const long TILE_CM_ALT_VALUE = 0xFF6F757B;
        public const long TILE_CMF_DEFAULT_VALUE = 0xFF2D343D;
        public const long TILE_LM_DEFAULT_VALUE = 0xFF99A6B5;
		public const long TILE_AR_VALUE = 0xFFF5368E;
		public const long TILE_CAPEX_VALUE = 0xFF34C04E;
		public const long TILE_INV_VALUE = 0xFFF2C97DA;
		public const long TILE_NEGATIVE_VALUE = 0xFF2C97DA;
        public const long TILE_CM_POSITIVE_VALUE = 0xFF2D343D;
        public const long TILE_CM_NEGATIVE_VALUE = 0xFF2D343D;
		public const long TILE_POSITIVE_VALUE = 0xFF34C04E;
		public const long TILE_NORMAL_VALUE = 0xFF99ACC0;
        public const long TILE_CASH_AR_LABEL = 0xFF2C97DA;
        public const long TILE_REV_VALUE = 0xFF2C97DA;
        public const long TILE_IBT_VALUE = 0xFF34C04E;

		//TableView Colours
		public const long TABLEVIEW_ALTERNATEROW_VALUE = 0xFFF9F9F9;
		public const long TABLEVIEW_SELECTEDEROW_VALUE = 0xFF8D949A;
		public const long TABLEVIEW_UNSELECTEDEROW_VALUE = 0xFF6F757B;
		public const long TABLEVIEW_HEADER_SELECTED_VALUE = 0xFF0A649C;

		//Gauge Colours
		public const long GAUGE_BASE = 0xFFDFDFDF;
		public const long REVENUE_SHADE = 0xFF2C97DA;
		public const long REVENUE_GRADIENT = 0xFF2CCFDA;
		public const long REVENUE_EXCEEDED = 0xFF2C97DA;
		public const long REVENUE_EXCEEDED_GRADIENT = 0xFF77F6FF;

		public const long AR_SHADE = 0xFF2C97DA;
		public const long AR_GRADIENT = 0xFF2CCFDA;
		public const long CAPEX_SHADE = 0xFF34C04E;
		public const long CAPEX_GRADIENT = 0xFF8DF068;
		public const long INVENTORY_SHADE = 0xFF7F79D3;
		public const long INVENTORY_GRADIENT = 0xFFC379D3;

		public const long IBT_SHADE = 0xFF34C04E;
		public const long IBT_GRADIENT = 0xFF8DF068;
		public const long IBT_EXCEEDED = 0xFF34C04E;
		public const long IBT_EXCEEDED_GRADIENT = 0xFFAAFB6D;

		//BAR Colours
		public const long BAR_COLOUR = 0xFF34C04E;
		public const long BAR_GRADIENT_COLOUR = 0xFF8EDE52;
		public const long BAR_END_COLOUR = 0xFF99ACC0;
		public const long BAR_END_GRADIENT_COLOUR = 0xFFC4D2E0;

		//BAR CIRCLE COLOURS
		public const long CIRCLE_COLOUR = 0xFF2C97DA;
		public const long CIRCLE_BORDER_COLOUR = 0xFFFFFFFF;

		//FILTER Colours
		public const long FILTER_MODAL_BORDER = 0xFF99A1AE;
		public const long FILTER_BUTTON_SELECTION_BG = 0xFF596272;
		public const long FILTER_BUTTON_NORMAL_BG = 0xFF959CA9;
		public const long FILTER_BUTTON_SELECTION_TEXT = 0xFFFFFFFF;
		public const long FILTER_BUTTON_NORMAL_TEXT = 0xFFFCFCFC;

        //Bar Chart pop-up
        public const long CHART_POPUP_BACKGROUND = 0xFF959CA9;
        public const long CHART_POPUP_TEXT_COLOR = 0xFFFCFCFC;

		//TABLE DIMENSION Mappings
		public const string TABLE_DIM_AR = "AR";
		public const string TABLE_DIM_DSO = "DSO";
		public const string TABLE_DIM_InvE = "InvE";
		public const string TABLE_DIM_InvF = "InvF";
		public const string TABLE_DIM_FTE = "FTE";
		public const string TABLE_DIM_NFTE = "NFTE";
		public const string TABLE_DIM_NI = "NI";
		public const string TABLE_DIM_WC_Add = "WC_Add";
		public const string TABLE_DIM_WC_Sub = "WC_Sub";
		public const string TABLE_DIM_IA = "IA";
		public const string TABLE_DIM_DEP = "DEP";

		//FILTER DIMENSION Mappings
		// :: BARS ::
		//REV = SR+PR+RR
		public const string FILTER_BAR_REV = "Rev";
		public const string FILTER_BAR_SR = "SR";
		public const string FILTER_BAR_PR = "PR";
		public const string FILTER_BAR_RR = "RR";
		public const string FILTER_BAR_JOBM = "JobM";
		// :: LINE GRAPH ::
		public const string FILTER_LINE_COMPENSATION = "COMP";
		public const string FILTER_LINE_MNS = "MS";
		public const string FILTER_LINE_DEPRECIATION = "DEP";
		public const string FILTER_LINE_LNR = "LR";
		public const string FILTER_LINE_TFC = "TFC";
		public const string FILTER_LINE_JOBM = "JobM";
		//FSC = SR+PR+RR - TFC
		public const string FILTER_LINE_SHAREDCOST = "SC";
		public const string FILTER_LINE_IBT = "IBT";
		public const string FILTER_LINE_TNM = "TM";
		// :: SUB_SEGMENT ::
		public const string FILTER_SUBSEGMENT_DNMLEGACY = "D&M Leg";
		public const string FILTER_SUBSEGMENT_GSS = "GSS";
		// :: PERIOD ::

		//Filter Button Title Text Display values
		// :: BARS ::
		public const string FILTER_BAR_REV_DISPLAY_TEXT = "Revenue";
		public const string FILTER_BAR_JOBM_DISPLAY_TEXT = "JobM";
		public const string FILTER_BAR_ARDSO_DISPLAY_TEXT = "AR|DSO";
		public const string FILTER_BAR_CAPEX_DISPLAY_TEXT = "CAPEX";
		public const string FILTER_BAR_INV_DISPLAY_TEXT = "Inventory";
		public const string FILTER_BAR_FCF_DISPLAY_TEXT = "Free Cash Flow";
		// :: LINE GRAPH ::
		public const string FILTER_LINE_DEPRECIATION_DISPLAY_TEXT = "Depreciation";
		public const string FILTER_LINE_COMPENSATION_DISPLAY_TEXT = "Compensation";
		public const string FILTER_LINE_TNM_DISPLAY_TEXT = "T&M";
		public const string FILTER_LINE_FSC_DISPLAY_TEXT = "FSC";
		public const string FILTER_LINE_LNR_DISPLAY_TEXT = "L&R";
		public const string FILTER_LINE_SC_DISPLAY_TEXT = "Shared Cost";
		public const string FILTER_LINE_MNS_DISPLAY_TEXT = "M&S";
		public const string FILTER_LINE_TFC_DISPLAY_TEXT = "TFC";
		public const string FILTER_LINE_IBT_DISPLAY_TEXT = "IBT";
        public const string FILTER_LINE_IBT_PERCENT_DISPLAY_TEXT = "IBT";
		//LINE GRAPH DISPLAY LINE AS
		public const string FILTER_LINE_DISPLAYAS_DOLLAR_TEXT = "$";
		public const string FILTER_LINE_DISPLAYAS_JOBS_TEXT = "jobs";
		public const string FILTER_LINE_DISPLAYAS_PERCENT_TEXT = "% of Revenue";
		public const string FILTER_LINE_DISPLAY_ONLYPERCENT_TEXT = "%";
		public const string FILTER_LINE_DISPLAYAS_PERJOBM_TEXT = "Per JobM";
		// :: SUB_SEGMENT ::
		public const string FILTER_SUBSEGMENT_DNMLEGACY_DISPLAY_TEXT = "Legacy D&M";
		public const string FILTER_SUBSEGMENT_GSS_DISPLAY_TEXT = "GSS";
		public const string FILTER_SUBSEGMENT_ALL_DISPLAY_TEXT = "All";
		// :: SUB_SEGMENT ::
		public const string FILTER_PERIOD_MONTHLY_DISPLAY_TEXT = "Monthly";
		public const string FILTER_PERIOD_QUARTERLY_DISPLAY_TEXT = "Quarterly";
		public const string FILTER_PERIOD_YEARLY_DISPLAY_TEXT = "Yearly";
		// :: CASH - Inventory Filter options
		public const string FILTER_CASH_AR_DSO_DISPLAY_TEXT = "AR|DSO";
		public const string FILTER_CASH_CAPEX_DISPLAY_TEXT = "Capex";
		public const string FILTER_CASH_INVENTORY_DISPLAY_TEXT = "Inventory";
		public const string FILTER_CASH_FCF_DISPLAY_TEXT = "Free Cash Flow";
		#endregion

		#region App Labels
		public const string EARNINGS_TEXT = "Earnings";
		public const string CASH_TEXT = "Cash";

		#endregion

		#region DashBoard Tiles Static Strings
		public const string HEADING_REVENUE = "REV";
		public const string HEADING_IBT = "IBT";
		public const string HEADING_AR = "AR";
		public const string HEADING_CAPEX = "CAPEX";
		public const string HEADING_INV = "INV";
		#endregion

		#region Chart Static Strings
		public const string CMF = "CMF";
		public const string LMF = "LM";
		public const string NMF = "NMF";
		public const string RR = "RR";
		public const string ROFO_RR = "ROFO RR";
		#endregion

		#region Chart Variables
		// drawing properties
		public const int DFM_TOP = 3;
		public const int DFM_LEFT = 5;
		public const int PADDING_BASE = 10;
		public const int DOT_WIDTH = 10;
		public const int MIN_BAR_WIDTH = 10;
		public const int MAX_BAR_WIDTH = 40;
		public const int BAR_GAP = 2;

		public const int NAVIGATIONSTATE2_CHART_HEGHT = 285;
		public const int NAVIGATIONSTATE1_FILTER_YPOS = 368;
		public const int NAVIGATIONSTATE2_FILTER_YPOS = 20;//225
		public const int NAVIGATIONSTATE1_CHART_YPOS = 0;
		public const int NAVIGATIONSTATE2_CHART_YPOS = 52;

		// num bars per period type - not including cmf, nmf, q# rr
		public const int MONTH_COUNT = 25;
		public const int QUARTER_COUNT = 9;
		public const int YEAR_COUNT = 3;

		// chart static vars
		public const int MONTHS_PER_YEAR = 12;
		public const int MONTH_START = 1;
		// digit to compare to strip out year in chart cell.
		public const string YEAR_DIGIT = "2";

		// Y Axis num items
		public const int NUM_TICKS = 4;
		public const int OFFSET_DIVISOR = 2;
		public const int MICRO_OFFSET = 2;

		// if we don't use a dummy item to fake columns in right place, make this 0
		public const int DUMMY_CT = 1;
		#endregion

		#region Local State Variables 
		// line types - NOT to Data map, local state ONLY
		public static int VALUE = 0;
		public static int PERCENT_REVENUE = 1;
		public static int PERJOBM = 2;

		// period types - NOT to Data map, local state ONLY
		public const int MONTH = 0;
		public const int QUARTER = 1;
		public const int YEAR = 2;
		#endregion

		#region Utility Statics	
		// Period starters for Chart labels - used for identifying year start
		public const string P_MONTH = "Jan";
		public const string P_QUARTER = "Q1";
		public const string P_YEAR = "01";
		public const string MISSING_DATA = "XXX";
		#endregion

		#region MAP Connectors	
		// connectors are local static variables that map items by NAME. Ids change, Names should not.
		// Connectors for VIEW
		public const string ACTUAL = "Actual";
		public const string M_FCST = "Mthly_Fcst";
		public const string Q_FCST = "Qtrly_Fcst";

		// Connectors for Earning bars
		// NOTE: revenue is includes 3 strings=> compound dimension
		public const string REV = "Revenue";
		public static List<string> REV_CONNECTORS => new List<string> { "SR", "PR", "RR" };
		public const string JOBM = "JobM";

		// Connectors for Cash bars
		public const string AR = "AR";
		public const string DSO = "DSO";
		public const string FCF_TEXT = "FCF";
		public static List<string> INVENTORY_CONNECTORS => new List<string> { "InvF", "InvE" };
		public static List<string> CAPEX_CONNECTORS => new List<string> { "FTE", "NFTE" };
		public static List<string> ARDSO_CONNECTORS => new List<string> { "AR", "DSO" };
		public static List<string> FSC_CONNECTORS => new List<string> { "SR", "PR", "RR", "TFC" };

		// Connectors for Earning lines
		public const string IBT_CONNECTOR = "IBT";
		// flag for FCF
		public const int FCF = 999999;

		#endregion

		#region Settings
		public const string EmailSubjectText = "KPI Reporter Feedback";
		public const string EmailUserLabel = "User:";
		public const string EmailDataUpdatedLabel = "Data Last Updated:";
		public const string EmailAppVersionLabel = "App Version:";
		public const string EmailToAddress = "KPIReporter@slb.com";
		public const string EmailIncompatibilityErrorMessage = "Email function is not configured on this device.";
		public const string EmailSmsIncompatibilityErrorTitle = "Email not configured";
		public const string Ok = "OK";
		#endregion

		#region Misc Strings
		public const string NewDataDownloadedMessage = "New data downloaded. Do you want to refresh the app?";
		public const string DATA_LOADING_MEESAGE = "Loading Data";
		public const string DATA_DOWNLOADING_MEESAGE = "Downloading Data";
		public const string DATA_PROCESSING_MEESAGE = "Processing Data";
		public const string SETTINGS_REFRESH_BUTTON_TEXT = "Refresh Data";
		public const string SETTINGS_REFRESH_UPDATE_BUTTON_TEXT = "Check for Updated Data";
 	    #endregion

	}
}
