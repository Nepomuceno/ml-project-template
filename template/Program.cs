using System;
using Microsoft.ML;
using Microsoft.ML.Transforms;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Runtime.Api;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace ml.template
{
    public class Fact
    {
#if (datasource == "stackoverflow/stack-overflow-2018-developer-survey")

		//Description: The respondent of the survey.
		[Column(ordinal: "0")]
		public float Respondent

		//Description: 
		[Column(ordinal: "1")]
		public string Hobby

		//Description: 
		[Column(ordinal: "2")]
		public string OpenSource

		//Description: 
		[Column(ordinal: "3")]
		public string Country

		//Description: 
		[Column(ordinal: "4")]
		public string Student

		//Description: 
		[Column(ordinal: "5")]
		public string Employment

		//Description: 
		[Column(ordinal: "6")]
		public string FormalEducation

		//Description: 
		[Column(ordinal: "7")]
		public string UndergradMajor

		//Description: 
		[Column(ordinal: "8")]
		public string CompanySize

		//Description: 
		[Column(ordinal: "9")]
		public string DevType

		//Description: 
		[Column(ordinal: "10")]
		public string YearsCoding

		//Description: 
		[Column(ordinal: "11")]
		public string YearsCodingProf

		//Description: 
		[Column(ordinal: "12")]
		public string JobSatisfaction

		//Description: 
		[Column(ordinal: "13")]
		public string CareerSatisfaction

		//Description: 
		[Column(ordinal: "14")]
		public string HopeFiveYears

		//Description: 
		[Column(ordinal: "15")]
		public string JobSearchStatus

		//Description: 
		[Column(ordinal: "16")]
		public string LastNewJob

		//Description: 
		[Column(ordinal: "17")]
		public string AssessJob1

		//Description: 
		[Column(ordinal: "18")]
		public string AssessJob2

		//Description: 
		[Column(ordinal: "19")]
		public string AssessJob3

		//Description: 
		[Column(ordinal: "20")]
		public string AssessJob4

		//Description: 
		[Column(ordinal: "21")]
		public string AssessJob5

		//Description: 
		[Column(ordinal: "22")]
		public string AssessJob6

		//Description: 
		[Column(ordinal: "23")]
		public string AssessJob7

		//Description: 
		[Column(ordinal: "24")]
		public string AssessJob8

		//Description: 
		[Column(ordinal: "25")]
		public string AssessJob9

		//Description: 
		[Column(ordinal: "26")]
		public string AssessJob10

		//Description: 
		[Column(ordinal: "27")]
		public string AssessBenefits1

		//Description: 
		[Column(ordinal: "28")]
		public string AssessBenefits2

		//Description: 
		[Column(ordinal: "29")]
		public string AssessBenefits3

		//Description: 
		[Column(ordinal: "30")]
		public string AssessBenefits4

		//Description: 
		[Column(ordinal: "31")]
		public string AssessBenefits5

		//Description: 
		[Column(ordinal: "32")]
		public string AssessBenefits6

		//Description: 
		[Column(ordinal: "33")]
		public string AssessBenefits7

		//Description: 
		[Column(ordinal: "34")]
		public string AssessBenefits8

		//Description: 
		[Column(ordinal: "35")]
		public string AssessBenefits9

		//Description: 
		[Column(ordinal: "36")]
		public string AssessBenefits10

		//Description: 
		[Column(ordinal: "37")]
		public string AssessBenefits11

		//Description: 
		[Column(ordinal: "38")]
		public string JobContactPriorities1

		//Description: 
		[Column(ordinal: "39")]
		public string JobContactPriorities2

		//Description: 
		[Column(ordinal: "40")]
		public string JobContactPriorities3

		//Description: 
		[Column(ordinal: "41")]
		public string JobContactPriorities4

		//Description: 
		[Column(ordinal: "42")]
		public string JobContactPriorities5

		//Description: 
		[Column(ordinal: "43")]
		public string JobEmailPriorities1

		//Description: 
		[Column(ordinal: "44")]
		public string JobEmailPriorities2

		//Description: 
		[Column(ordinal: "45")]
		public string JobEmailPriorities3

		//Description: 
		[Column(ordinal: "46")]
		public string JobEmailPriorities4

		//Description: 
		[Column(ordinal: "47")]
		public string JobEmailPriorities5

		//Description: 
		[Column(ordinal: "48")]
		public string JobEmailPriorities6

		//Description: 
		[Column(ordinal: "49")]
		public string JobEmailPriorities7

		//Description: 
		[Column(ordinal: "50")]
		public string UpdateCV

		//Description: 
		[Column(ordinal: "51")]
		public string Currency

		//Description: 
		[Column(ordinal: "52")]
		public string Salary

		//Description: 
		[Column(ordinal: "53")]
		public string SalaryType

		//Description: 
		[Column(ordinal: "54")]
		public string ConvertedSalary

		//Description: 
		[Column(ordinal: "55")]
		public string CurrencySymbol

		//Description: 
		[Column(ordinal: "56")]
		public string CommunicationTools

		//Description: 
		[Column(ordinal: "57")]
		public string TimeFullyProductive

		//Description: 
		[Column(ordinal: "58")]
		public string EducationTypes

		//Description: 
		[Column(ordinal: "59")]
		public string SelfTaughtTypes

		//Description: 
		[Column(ordinal: "60")]
		public string TimeAfterBootcamp

		//Description: 
		[Column(ordinal: "61")]
		public string HackathonReasons

		//Description: 
		[Column(ordinal: "62")]
		public string AgreeDisagree1

		//Description: 
		[Column(ordinal: "63")]
		public string AgreeDisagree2

		//Description: 
		[Column(ordinal: "64")]
		public string AgreeDisagree3

		//Description: 
		[Column(ordinal: "65")]
		public string LanguageWorkedWith

		//Description: 
		[Column(ordinal: "66")]
		public string LanguageDesireNextYear

		//Description: 
		[Column(ordinal: "67")]
		public string DatabaseWorkedWith

		//Description: 
		[Column(ordinal: "68")]
		public string DatabaseDesireNextYear

		//Description: 
		[Column(ordinal: "69")]
		public string PlatformWorkedWith

		//Description: 
		[Column(ordinal: "70")]
		public string PlatformDesireNextYear

		//Description: 
		[Column(ordinal: "71")]
		public string FrameworkWorkedWith

		//Description: 
		[Column(ordinal: "72")]
		public string FrameworkDesireNextYear

		//Description: 
		[Column(ordinal: "73")]
		public string IDE

		//Description: 
		[Column(ordinal: "74")]
		public string OperatingSystem

		//Description: 
		[Column(ordinal: "75")]
		public string NumberMonitors

		//Description: 
		[Column(ordinal: "76")]
		public string Methodology

		//Description: 
		[Column(ordinal: "77")]
		public string VersionControl

		//Description: 
		[Column(ordinal: "78")]
		public string CheckInCode

		//Description: 
		[Column(ordinal: "79")]
		public string AdBlocker

		//Description: 
		[Column(ordinal: "80")]
		public string AdBlockerDisable

		//Description: 
		[Column(ordinal: "81")]
		public string AdBlockerReasons

		//Description: 
		[Column(ordinal: "82")]
		public string AdsAgreeDisagree1

		//Description: 
		[Column(ordinal: "83")]
		public string AdsAgreeDisagree2

		//Description: 
		[Column(ordinal: "84")]
		public string AdsAgreeDisagree3

		//Description: 
		[Column(ordinal: "85")]
		public string AdsActions

		//Description: 
		[Column(ordinal: "86")]
		public string AdsPriorities1

		//Description: 
		[Column(ordinal: "87")]
		public string AdsPriorities2

		//Description: 
		[Column(ordinal: "88")]
		public string AdsPriorities3

		//Description: 
		[Column(ordinal: "89")]
		public string AdsPriorities4

		//Description: 
		[Column(ordinal: "90")]
		public string AdsPriorities5

		//Description: 
		[Column(ordinal: "91")]
		public string AdsPriorities6

		//Description: 
		[Column(ordinal: "92")]
		public string AdsPriorities7

		//Description: 
		[Column(ordinal: "93")]
		public string AIDangerous

		//Description: 
		[Column(ordinal: "94")]
		public string AIInteresting

		//Description: 
		[Column(ordinal: "95")]
		public string AIResponsible

		//Description: 
		[Column(ordinal: "96")]
		public string AIFuture

		//Description: 
		[Column(ordinal: "97")]
		public string EthicsChoice

		//Description: 
		[Column(ordinal: "98")]
		public string EthicsReport

		//Description: 
		[Column(ordinal: "99")]
		public string EthicsResponsible

		//Description: 
		[Column(ordinal: "100")]
		public string EthicalImplications

		//Description: 
		[Column(ordinal: "101")]
		public string StackOverflowRecommend

		//Description: 
		[Column(ordinal: "102")]
		public string StackOverflowVisit

		//Description: 
		[Column(ordinal: "103")]
		public string StackOverflowHasAccount

		//Description: 
		[Column(ordinal: "104")]
		public string StackOverflowParticipate

		//Description: 
		[Column(ordinal: "105")]
		public string StackOverflowJobs

		//Description: 
		[Column(ordinal: "106")]
		public string StackOverflowDevStory

		//Description: 
		[Column(ordinal: "107")]
		public string StackOverflowJobsRecommend

		//Description: 
		[Column(ordinal: "108")]
		public string StackOverflowConsiderMember

		//Description: 
		[Column(ordinal: "109")]
		public string HypotheticalTools1

		//Description: 
		[Column(ordinal: "110")]
		public string HypotheticalTools2

		//Description: 
		[Column(ordinal: "111")]
		public string HypotheticalTools3

		//Description: 
		[Column(ordinal: "112")]
		public string HypotheticalTools4

		//Description: 
		[Column(ordinal: "113")]
		public string HypotheticalTools5

		//Description: 
		[Column(ordinal: "114")]
		public string WakeTime

		//Description: 
		[Column(ordinal: "115")]
		public string HoursComputer

		//Description: 
		[Column(ordinal: "116")]
		public string HoursOutside

		//Description: 
		[Column(ordinal: "117")]
		public string SkipMeals

		//Description: 
		[Column(ordinal: "118")]
		public string ErgonomicDevices

		//Description: 
		[Column(ordinal: "119")]
		public string Exercise

		//Description: 
		[Column(ordinal: "120")]
		public string Gender

		//Description: 
		[Column(ordinal: "121")]
		public string SexualOrientation

		//Description: 
		[Column(ordinal: "122")]
		public string EducationParents

		//Description: 
		[Column(ordinal: "123")]
		public string RaceEthnicity

		//Description: 
		[Column(ordinal: "124")]
		public string Age

		//Description: 
		[Column(ordinal: "125")]
		public string Dependents

		//Description: 
		[Column(ordinal: "126")]
		public string MilitaryUS

		//Description: 
		[Column(ordinal: "127")]
		public string SurveyTooLong

		//Description: 
		[Column(ordinal: "128")]
		public string SurveyEasy


#endif
#if (datasource == "jameslko/gun-violence-data")

		//Description: ID of the crime report
		[Column(ordinal: "0")]
		public float incident_id

		//Description: Date of crime
		[Column(ordinal: "1")]
		public DateTime date

		//Description: State of crime
		[Column(ordinal: "2")]
		public string state

		//Description: City/ County of crime
		[Column(ordinal: "3")]
		public string city_or_county

		//Description: Address of the location of the crime
		[Column(ordinal: "4")]
		public string address

		//Description: Number of people killed
		[Column(ordinal: "5")]
		public float n_killed

		//Description: Number of people injured
		[Column(ordinal: "6")]
		public float n_injured

		//Description: URL regarding the incident
		[Column(ordinal: "7")]
		public string incident_url

		//Description: Reference to the reporting source
		[Column(ordinal: "8")]
		public string source_url

		//Description: TRUE if the incident_url is present, FALSE otherwise
		[Column(ordinal: "9")]
		public bool incident_url_fields_missing

		//Description: Congressional district id
		[Column(ordinal: "10")]
		public float congressional_district

		//Description: Status of guns involved in the crime (i.e. Unknown, Stolen, etc...)
		[Column(ordinal: "11")]
		public string gun_stolen

		//Description: Typification of guns used in the crime
		[Column(ordinal: "12")]
		public string gun_type

		//Description: Characteristics of the incidence
		[Column(ordinal: "13")]
		public string incident_characteristics

		//Description: Location of the incident
		[Column(ordinal: "14")]
		public float latitude

		//Description: 
		[Column(ordinal: "15")]
		public string location_description

		//Description: Location of the incident
		[Column(ordinal: "16")]
		public float longitude

		//Description: Number of guns involved in incident
		[Column(ordinal: "17")]
		public string n_guns_involved

		//Description: Additional information of the crime
		[Column(ordinal: "18")]
		public string notes

		//Description: Age of participant(s) at the time of crime
		[Column(ordinal: "19")]
		public string participant_age

		//Description: Age group of participant(s) at the time crime
		[Column(ordinal: "20")]
		public string participant_age_group

		//Description: Gender of participant(s)
		[Column(ordinal: "21")]
		public string participant_gender

		//Description: Name of participant(s) involved in crime
		[Column(ordinal: "22")]
		public string participant_name

		//Description: Relationship of participant to other participant(s)
		[Column(ordinal: "23")]
		public string participant_relationship

		//Description: Extent of harm done to the participant
		[Column(ordinal: "24")]
		public string participant_status

		//Description: Type of participant
		[Column(ordinal: "25")]
		public string participant_type

		//Description: 
		[Column(ordinal: "26")]
		public string sources

		//Description: 
		[Column(ordinal: "27")]
		public string state_house_district

		//Description: 
		[Column(ordinal: "28")]
		public string state_senate_district


#endif
#if (datasource == "donorschoose/io")


#endif
#if (datasource == "datafiniti/grammar-and-online-product-reviews")

		//Description: 
		[Column(ordinal: "0")]
		public string id

		//Description: 
		[Column(ordinal: "1")]
		public string brand

		//Description: 
		[Column(ordinal: "2")]
		public string categories

		//Description: 
		[Column(ordinal: "3")]
		public DateTime dateAdded

		//Description: 
		[Column(ordinal: "4")]
		public DateTime dateUpdated

		//Description: 
		[Column(ordinal: "5")]
		public float ean

		//Description: 
		[Column(ordinal: "6")]
		public string keys

		//Description: 
		[Column(ordinal: "7")]
		public string manufacturer

		//Description: 
		[Column(ordinal: "8")]
		public float manufacturerNumber

		//Description: 
		[Column(ordinal: "9")]
		public string name

		//Description: 
		[Column(ordinal: "10")]
		public DateTime reviews.date

		//Description: 
		[Column(ordinal: "11")]
		public DateTime reviews.dateAdded

		//Description: 
		[Column(ordinal: "12")]
		public string reviews.dateSeen

		//Description: 
		[Column(ordinal: "13")]
		public string reviews.didPurchase

		//Description: 
		[Column(ordinal: "14")]
		public string reviews.doRecommend

		//Description: 
		[Column(ordinal: "15")]
		public string reviews.id

		//Description: 
		[Column(ordinal: "16")]
		public string reviews.numHelpful

		//Description: 
		[Column(ordinal: "17")]
		public float reviews.rating

		//Description: 
		[Column(ordinal: "18")]
		public string reviews.sourceURLs

		//Description: 
		[Column(ordinal: "19")]
		public string reviews.text

		//Description: 
		[Column(ordinal: "20")]
		public string reviews.title

		//Description: 
		[Column(ordinal: "21")]
		public string reviews.userCity

		//Description: 
		[Column(ordinal: "22")]
		public string reviews.userProvince

		//Description: 
		[Column(ordinal: "23")]
		public string reviews.username

		//Description: 
		[Column(ordinal: "24")]
		public float upc


#endif
#if (datasource == "ruslankl/mice-protein-expression")

		//Description: 
		[Column(ordinal: "0")]
		public string MouseID

		//Description: 
		[Column(ordinal: "1")]
		public float DYRK1A_N

		//Description: 
		[Column(ordinal: "2")]
		public float ITSN1_N

		//Description: 
		[Column(ordinal: "3")]
		public float BDNF_N

		//Description: 
		[Column(ordinal: "4")]
		public float NR1_N

		//Description: 
		[Column(ordinal: "5")]
		public float NR2A_N

		//Description: 
		[Column(ordinal: "6")]
		public float pAKT_N

		//Description: 
		[Column(ordinal: "7")]
		public float pBRAF_N

		//Description: 
		[Column(ordinal: "8")]
		public float pCAMKII_N

		//Description: 
		[Column(ordinal: "9")]
		public float pCREB_N

		//Description: 
		[Column(ordinal: "10")]
		public float pELK_N

		//Description: 
		[Column(ordinal: "11")]
		public float pERK_N

		//Description: 
		[Column(ordinal: "12")]
		public float pJNK_N

		//Description: 
		[Column(ordinal: "13")]
		public float PKCA_N

		//Description: 
		[Column(ordinal: "14")]
		public float pMEK_N

		//Description: 
		[Column(ordinal: "15")]
		public float pNR1_N

		//Description: 
		[Column(ordinal: "16")]
		public float pNR2A_N

		//Description: 
		[Column(ordinal: "17")]
		public float pNR2B_N

		//Description: 
		[Column(ordinal: "18")]
		public float pPKCAB_N

		//Description: 
		[Column(ordinal: "19")]
		public float pRSK_N

		//Description: 
		[Column(ordinal: "20")]
		public float AKT_N

		//Description: 
		[Column(ordinal: "21")]
		public float BRAF_N

		//Description: 
		[Column(ordinal: "22")]
		public float CAMKII_N

		//Description: 
		[Column(ordinal: "23")]
		public float CREB_N

		//Description: 
		[Column(ordinal: "24")]
		public float ELK_N

		//Description: 
		[Column(ordinal: "25")]
		public float ERK_N

		//Description: 
		[Column(ordinal: "26")]
		public float GSK3B_N

		//Description: 
		[Column(ordinal: "27")]
		public float JNK_N

		//Description: 
		[Column(ordinal: "28")]
		public float MEK_N

		//Description: 
		[Column(ordinal: "29")]
		public float TRKA_N

		//Description: 
		[Column(ordinal: "30")]
		public float RSK_N

		//Description: 
		[Column(ordinal: "31")]
		public float APP_N

		//Description: 
		[Column(ordinal: "32")]
		public float Bcatenin_N

		//Description: 
		[Column(ordinal: "33")]
		public float SOD1_N

		//Description: 
		[Column(ordinal: "34")]
		public float MTOR_N

		//Description: 
		[Column(ordinal: "35")]
		public float P38_N

		//Description: 
		[Column(ordinal: "36")]
		public float pMTOR_N

		//Description: 
		[Column(ordinal: "37")]
		public float DSCR1_N

		//Description: 
		[Column(ordinal: "38")]
		public float AMPKA_N

		//Description: 
		[Column(ordinal: "39")]
		public float NR2B_N

		//Description: 
		[Column(ordinal: "40")]
		public float pNUMB_N

		//Description: 
		[Column(ordinal: "41")]
		public float RAPTOR_N

		//Description: 
		[Column(ordinal: "42")]
		public float TIAM1_N

		//Description: 
		[Column(ordinal: "43")]
		public float pP70S6_N

		//Description: 
		[Column(ordinal: "44")]
		public float NUMB_N

		//Description: 
		[Column(ordinal: "45")]
		public float P70S6_N

		//Description: 
		[Column(ordinal: "46")]
		public float pGSK3B_N

		//Description: 
		[Column(ordinal: "47")]
		public float pPKCG_N

		//Description: 
		[Column(ordinal: "48")]
		public float CDK5_N

		//Description: 
		[Column(ordinal: "49")]
		public float S6_N

		//Description: 
		[Column(ordinal: "50")]
		public float ADARB1_N

		//Description: 
		[Column(ordinal: "51")]
		public float AcetylH3K9_N

		//Description: 
		[Column(ordinal: "52")]
		public float RRP1_N

		//Description: 
		[Column(ordinal: "53")]
		public float BAX_N

		//Description: 
		[Column(ordinal: "54")]
		public float ARC_N

		//Description: 
		[Column(ordinal: "55")]
		public float ERBB4_N

		//Description: 
		[Column(ordinal: "56")]
		public float nNOS_N

		//Description: 
		[Column(ordinal: "57")]
		public float Tau_N

		//Description: 
		[Column(ordinal: "58")]
		public float GFAP_N

		//Description: 
		[Column(ordinal: "59")]
		public float GluR3_N

		//Description: 
		[Column(ordinal: "60")]
		public float GluR4_N

		//Description: 
		[Column(ordinal: "61")]
		public float IL1B_N

		//Description: 
		[Column(ordinal: "62")]
		public float P3525_N

		//Description: 
		[Column(ordinal: "63")]
		public float pCASP9_N

		//Description: 
		[Column(ordinal: "64")]
		public float PSD95_N

		//Description: 
		[Column(ordinal: "65")]
		public float SNCA_N

		//Description: 
		[Column(ordinal: "66")]
		public float Ubiquitin_N

		//Description: 
		[Column(ordinal: "67")]
		public float pGSK3B_Tyr216_N

		//Description: 
		[Column(ordinal: "68")]
		public float SHH_N

		//Description: 
		[Column(ordinal: "69")]
		public string BAD_N

		//Description: 
		[Column(ordinal: "70")]
		public string BCL2_N

		//Description: 
		[Column(ordinal: "71")]
		public float pS6_N

		//Description: 
		[Column(ordinal: "72")]
		public string pCFOS_N

		//Description: 
		[Column(ordinal: "73")]
		public float SYP_N

		//Description: 
		[Column(ordinal: "74")]
		public string H3AcK18_N

		//Description: 
		[Column(ordinal: "75")]
		public string EGR1_N

		//Description: 
		[Column(ordinal: "76")]
		public string H3MeK4_N

		//Description: 
		[Column(ordinal: "77")]
		public float CaNA_N

		//Description: 
		[Column(ordinal: "78")]
		public string Genotype

		//Description: 
		[Column(ordinal: "79")]
		public string Treatment

		//Description: 
		[Column(ordinal: "80")]
		public string Behavior

		//Description: 
		[Column(ordinal: "81")]
		public string class


#endif
#if (datasource == "jessicali9530/honey-production")

		//Description: State name abbreviation
		[Column(ordinal: "0")]
		public string state

		//Description: Number of honey producing colonies
		[Column(ordinal: "1")]
		public float numcol

		//Description: Yield per colony (lbs)
		[Column(ordinal: "2")]
		public float yieldpercol

		//Description: Total production (numcol*yieldpercol), (lbs)
		[Column(ordinal: "3")]
		public float totalprod

		//Description: Stocks held by producers on Dec 15 (lbs)
		[Column(ordinal: "4")]
		public float stocks

		//Description: Average price per pound ($)
		[Column(ordinal: "5")]
		public float priceperlb

		//Description: Value of production (totalprod*prodvalue), ($)
		[Column(ordinal: "6")]
		public float prodvalue

		//Description: Year the data pertains to
		[Column(ordinal: "7")]
		public float year


#endif
#if (datasource == "unitednations/global-commodity-trade-statistics")

		//Description: 
		[Column(ordinal: "0")]
		public string country_or_area

		//Description: Year in which the trade has taken place
		[Column(ordinal: "1")]
		public float year

		//Description: 
		[Column(ordinal: "2")]
		public float comm_code

		//Description: 
		[Column(ordinal: "3")]
		public string commodity

		//Description: 
		[Column(ordinal: "4")]
		public string flow

		//Description: Value of the trade in USD
		[Column(ordinal: "5")]
		public float trade_usd

		//Description: 
		[Column(ordinal: "6")]
		public float weight_kg

		//Description: 
		[Column(ordinal: "7")]
		public string quantity_name

		//Description: 
		[Column(ordinal: "8")]
		public float quantity

		//Description: Category to identify commodity
		[Column(ordinal: "9")]
		public string category


#endif
#if (datasource == "goldenoakresearch/us-acs-mortgage-equity-loans-rent-statistics")

		//Description: 
		[Column(ordinal: "0")]
		public float UID

		//Description: 
		[Column(ordinal: "1")]
		public string BLOCKID

		//Description: 
		[Column(ordinal: "2")]
		public float SUMLEVEL

		//Description: 
		[Column(ordinal: "3")]
		public float COUNTYID

		//Description: 
		[Column(ordinal: "4")]
		public float STATEID

		//Description: 
		[Column(ordinal: "5")]
		public string state

		//Description: 
		[Column(ordinal: "6")]
		public string state_ab

		//Description: 所在城市
		[Column(ordinal: "7")]
		public string city

		//Description: 
		[Column(ordinal: "8")]
		public string place

		//Description: 城市或乡镇或普查定居点;City/Town/CDP
		[Column(ordinal: "9")]
		public string type

		//Description: 
		[Column(ordinal: "10")]
		public string primary

		//Description: 
		[Column(ordinal: "11")]
		public float zip_code

		//Description: 
		[Column(ordinal: "12")]
		public float area_code

		//Description: 
		[Column(ordinal: "13")]
		public float lat

		//Description: 
		[Column(ordinal: "14")]
		public float lng

		//Description: 
		[Column(ordinal: "15")]
		public float ALand

		//Description: 
		[Column(ordinal: "16")]
		public float AWater

		//Description: 
		[Column(ordinal: "17")]
		public float pop

		//Description: 
		[Column(ordinal: "18")]
		public float male_pop

		//Description: 
		[Column(ordinal: "19")]
		public float female_pop

		//Description: 
		[Column(ordinal: "20")]
		public float rent_mean

		//Description: 
		[Column(ordinal: "21")]
		public float rent_median

		//Description: 
		[Column(ordinal: "22")]
		public float rent_stdev

		//Description: 
		[Column(ordinal: "23")]
		public float rent_sample_weight

		//Description: 
		[Column(ordinal: "24")]
		public float rent_samples

		//Description: 
		[Column(ordinal: "25")]
		public float rent_gt_10

		//Description: 
		[Column(ordinal: "26")]
		public float rent_gt_15

		//Description: 
		[Column(ordinal: "27")]
		public float rent_gt_20

		//Description: 
		[Column(ordinal: "28")]
		public float rent_gt_25

		//Description: 
		[Column(ordinal: "29")]
		public float rent_gt_30

		//Description: 
		[Column(ordinal: "30")]
		public float rent_gt_35

		//Description: 
		[Column(ordinal: "31")]
		public float rent_gt_40

		//Description: 
		[Column(ordinal: "32")]
		public float rent_gt_50

		//Description: 
		[Column(ordinal: "33")]
		public float universe_samples

		//Description: 
		[Column(ordinal: "34")]
		public float used_samples

		//Description: 
		[Column(ordinal: "35")]
		public float hi_mean

		//Description: 
		[Column(ordinal: "36")]
		public float hi_median

		//Description: 
		[Column(ordinal: "37")]
		public float hi_stdev

		//Description: 
		[Column(ordinal: "38")]
		public float hi_sample_weight

		//Description: 
		[Column(ordinal: "39")]
		public float hi_samples

		//Description: 
		[Column(ordinal: "40")]
		public float family_mean

		//Description: 
		[Column(ordinal: "41")]
		public float family_median

		//Description: 
		[Column(ordinal: "42")]
		public float family_stdev

		//Description: 
		[Column(ordinal: "43")]
		public float family_sample_weight

		//Description: 
		[Column(ordinal: "44")]
		public float family_samples

		//Description: 
		[Column(ordinal: "45")]
		public float hc_mortgage_mean

		//Description: 
		[Column(ordinal: "46")]
		public float hc_mortgage_median

		//Description: 
		[Column(ordinal: "47")]
		public float hc_mortgage_stdev

		//Description: 
		[Column(ordinal: "48")]
		public float hc_mortgage_sample_weight

		//Description: 
		[Column(ordinal: "49")]
		public float hc_mortgage_samples

		//Description: 
		[Column(ordinal: "50")]
		public float hc_mean

		//Description: 
		[Column(ordinal: "51")]
		public float hc_median

		//Description: 
		[Column(ordinal: "52")]
		public float hc_stdev

		//Description: 
		[Column(ordinal: "53")]
		public float hc_samples

		//Description: 
		[Column(ordinal: "54")]
		public float hc_sample_weight

		//Description: 
		[Column(ordinal: "55")]
		public float home_equity_second_mortgage

		//Description: 
		[Column(ordinal: "56")]
		public float second_mortgage

		//Description: 
		[Column(ordinal: "57")]
		public float home_equity

		//Description: 
		[Column(ordinal: "58")]
		public float debt

		//Description: 
		[Column(ordinal: "59")]
		public float second_mortgage_cdf

		//Description: 
		[Column(ordinal: "60")]
		public float home_equity_cdf

		//Description: 
		[Column(ordinal: "61")]
		public float debt_cdf

		//Description: 
		[Column(ordinal: "62")]
		public float hs_degree

		//Description: 
		[Column(ordinal: "63")]
		public float hs_degree_male

		//Description: 
		[Column(ordinal: "64")]
		public float hs_degree_female

		//Description: 
		[Column(ordinal: "65")]
		public float male_age_mean

		//Description: 
		[Column(ordinal: "66")]
		public float male_age_median

		//Description: 
		[Column(ordinal: "67")]
		public float male_age_stdev

		//Description: 
		[Column(ordinal: "68")]
		public float male_age_sample_weight

		//Description: 
		[Column(ordinal: "69")]
		public float male_age_samples

		//Description: 
		[Column(ordinal: "70")]
		public float female_age_mean

		//Description: 
		[Column(ordinal: "71")]
		public float female_age_median

		//Description: 
		[Column(ordinal: "72")]
		public float female_age_stdev

		//Description: 
		[Column(ordinal: "73")]
		public float female_age_sample_weight

		//Description: 
		[Column(ordinal: "74")]
		public float female_age_samples

		//Description: 
		[Column(ordinal: "75")]
		public float pct_own

		//Description: 
		[Column(ordinal: "76")]
		public float married

		//Description: 
		[Column(ordinal: "77")]
		public float married_snp

		//Description: 
		[Column(ordinal: "78")]
		public float separated

		//Description: 
		[Column(ordinal: "79")]
		public float divorced


#endif
#if (datasource == "ainslie/usda-wasde-monthly-corn-soybean-projections")


#endif
#if (datasource == "vikasg/russian-troll-tweets")

		//Description: 
		[Column(ordinal: "0")]
		public float user_id

		//Description: 
		[Column(ordinal: "1")]
		public string user_key

		//Description: 
		[Column(ordinal: "2")]
		public float created_at

		//Description: 
		[Column(ordinal: "3")]
		public DateTime created_str

		//Description: 
		[Column(ordinal: "4")]
		public string retweet_count

		//Description: 
		[Column(ordinal: "5")]
		public string retweeted

		//Description: 
		[Column(ordinal: "6")]
		public string favorite_count

		//Description: 
		[Column(ordinal: "7")]
		public string text

		//Description: 
		[Column(ordinal: "8")]
		public float tweet_id

		//Description: Utility used to post the Tweet, as an HTML-formatted string. Tweets from the Twitter website have a source value of web.
		[Column(ordinal: "9")]
		public string source

		//Description: 
		[Column(ordinal: "10")]
		public string hashtags

		//Description: 
		[Column(ordinal: "11")]
		public string expanded_urls

		//Description: 
		[Column(ordinal: "12")]
		public string posted

		//Description: 
		[Column(ordinal: "13")]
		public string mentions

		//Description: 
		[Column(ordinal: "14")]
		public string retweeted_status_id

		//Description: 
		[Column(ordinal: "15")]
		public string in_reply_to_status_id


#endif

    }
    public class Output
    {
        [ColumnName("Score")]
        public string Score;

        [ColumnName("PredictedLabel")]
        public string PredictedLabel;
    }

    class Program
    {

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bmVwb211Y2VubzoyYTQ0NDFmZGRmNzA0NGE1YTU1OGUzNTlkMTQwMjgyZg==");
            client.BaseAddress = new Uri("https://www.kaggle.com/api/v1");
            if (!File.Exists("./datasource/source.csv"))
            {
#if (datasource == "stackoverflow/stack-overflow-2018-developer-survey")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/stackoverflow/stack-overflow-2018-developer-survey/survey_results_public.csv").Result;
#endif
#if (datasource == "jameslko/gun-violence-data")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/jameslko/gun-violence-data/gun-violence-data_01-2013_03-2018.csv").Result;
#endif
#if (datasource == "donorschoose/io")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/donorschoose/io/Projects.csv").Result;
#endif
#if (datasource == "datafiniti/grammar-and-online-product-reviews")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/datafiniti/grammar-and-online-product-reviews/GrammarandProductReviews.csv").Result;
#endif
#if (datasource == "ruslankl/mice-protein-expression")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/ruslankl/mice-protein-expression/Data_Cortex_Nuclear.csv").Result;
#endif
#if (datasource == "jessicali9530/honey-production")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/jessicali9530/honey-production/honeyproduction.csv").Result;
#endif
#if (datasource == "unitednations/global-commodity-trade-statistics")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/unitednations/global-commodity-trade-statistics/commodity_trade_statistics_data.csv").Result;
#endif
#if (datasource == "goldenoakresearch/us-acs-mortgage-equity-loans-rent-statistics")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/goldenoakresearch/us-acs-mortgage-equity-loans-rent-statistics/real_estate_db.csv").Result;
#endif
#if (datasource == "ainslie/usda-wasde-monthly-corn-soybean-projections")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/ainslie/usda-wasde-monthly-corn-soybean-projections/corn_JUL14.txt").Result;
#endif
#if (datasource == "vikasg/russian-troll-tweets")
var fileContent = client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/download/vikasg/russian-troll-tweets/tweets.csv").Result;
#endif

                File.WriteAllText("./datasource/source.csv",fileContent);
            }

            string[] Columns = new string[] {
#if (datasource == "stackoverflow/stack-overflow-2018-developer-survey")
			"Respondent",
			"Hobby",
			"OpenSource",
			"Country",
			"Student",
			"Employment",
			"FormalEducation",
			"UndergradMajor",
			"CompanySize",
			"DevType",
			"YearsCoding",
			"YearsCodingProf",
			"JobSatisfaction",
			"CareerSatisfaction",
			"HopeFiveYears",
			"JobSearchStatus",
			"LastNewJob",
			"AssessJob1",
			"AssessJob2",
			"AssessJob3",
			"AssessJob4",
			"AssessJob5",
			"AssessJob6",
			"AssessJob7",
			"AssessJob8",
			"AssessJob9",
			"AssessJob10",
			"AssessBenefits1",
			"AssessBenefits2",
			"AssessBenefits3",
			"AssessBenefits4",
			"AssessBenefits5",
			"AssessBenefits6",
			"AssessBenefits7",
			"AssessBenefits8",
			"AssessBenefits9",
			"AssessBenefits10",
			"AssessBenefits11",
			"JobContactPriorities1",
			"JobContactPriorities2",
			"JobContactPriorities3",
			"JobContactPriorities4",
			"JobContactPriorities5",
			"JobEmailPriorities1",
			"JobEmailPriorities2",
			"JobEmailPriorities3",
			"JobEmailPriorities4",
			"JobEmailPriorities5",
			"JobEmailPriorities6",
			"JobEmailPriorities7",
			"UpdateCV",
			"Currency",
			"Salary",
			"SalaryType",
			"ConvertedSalary",
			"CurrencySymbol",
			"CommunicationTools",
			"TimeFullyProductive",
			"EducationTypes",
			"SelfTaughtTypes",
			"TimeAfterBootcamp",
			"HackathonReasons",
			"AgreeDisagree1",
			"AgreeDisagree2",
			"AgreeDisagree3",
			"LanguageWorkedWith",
			"LanguageDesireNextYear",
			"DatabaseWorkedWith",
			"DatabaseDesireNextYear",
			"PlatformWorkedWith",
			"PlatformDesireNextYear",
			"FrameworkWorkedWith",
			"FrameworkDesireNextYear",
			"IDE",
			"OperatingSystem",
			"NumberMonitors",
			"Methodology",
			"VersionControl",
			"CheckInCode",
			"AdBlocker",
			"AdBlockerDisable",
			"AdBlockerReasons",
			"AdsAgreeDisagree1",
			"AdsAgreeDisagree2",
			"AdsAgreeDisagree3",
			"AdsActions",
			"AdsPriorities1",
			"AdsPriorities2",
			"AdsPriorities3",
			"AdsPriorities4",
			"AdsPriorities5",
			"AdsPriorities6",
			"AdsPriorities7",
			"AIDangerous",
			"AIInteresting",
			"AIResponsible",
			"AIFuture",
			"EthicsChoice",
			"EthicsReport",
			"EthicsResponsible",
			"EthicalImplications",
			"StackOverflowRecommend",
			"StackOverflowVisit",
			"StackOverflowHasAccount",
			"StackOverflowParticipate",
			"StackOverflowJobs",
			"StackOverflowDevStory",
			"StackOverflowJobsRecommend",
			"StackOverflowConsiderMember",
			"HypotheticalTools1",
			"HypotheticalTools2",
			"HypotheticalTools3",
			"HypotheticalTools4",
			"HypotheticalTools5",
			"WakeTime",
			"HoursComputer",
			"HoursOutside",
			"SkipMeals",
			"ErgonomicDevices",
			"Exercise",
			"Gender",
			"SexualOrientation",
			"EducationParents",
			"RaceEthnicity",
			"Age",
			"Dependents",
			"MilitaryUS",
			"SurveyTooLong",
			"SurveyEasy"
#endif
#if (datasource == "jameslko/gun-violence-data")
			"incident_id",
			"date",
			"state",
			"city_or_county",
			"address",
			"n_killed",
			"n_injured",
			"incident_url",
			"source_url",
			"incident_url_fields_missing",
			"congressional_district",
			"gun_stolen",
			"gun_type",
			"incident_characteristics",
			"latitude",
			"location_description",
			"longitude",
			"n_guns_involved",
			"notes",
			"participant_age",
			"participant_age_group",
			"participant_gender",
			"participant_name",
			"participant_relationship",
			"participant_status",
			"participant_type",
			"sources",
			"state_house_district",
			"state_senate_district"
#endif
#if (datasource == "donorschoose/io")

#endif
#if (datasource == "datafiniti/grammar-and-online-product-reviews")
			"id",
			"brand",
			"categories",
			"dateAdded",
			"dateUpdated",
			"ean",
			"keys",
			"manufacturer",
			"manufacturerNumber",
			"name",
			"reviews.date",
			"reviews.dateAdded",
			"reviews.dateSeen",
			"reviews.didPurchase",
			"reviews.doRecommend",
			"reviews.id",
			"reviews.numHelpful",
			"reviews.rating",
			"reviews.sourceURLs",
			"reviews.text",
			"reviews.title",
			"reviews.userCity",
			"reviews.userProvince",
			"reviews.username",
			"upc"
#endif
#if (datasource == "ruslankl/mice-protein-expression")
			"MouseID",
			"DYRK1A_N",
			"ITSN1_N",
			"BDNF_N",
			"NR1_N",
			"NR2A_N",
			"pAKT_N",
			"pBRAF_N",
			"pCAMKII_N",
			"pCREB_N",
			"pELK_N",
			"pERK_N",
			"pJNK_N",
			"PKCA_N",
			"pMEK_N",
			"pNR1_N",
			"pNR2A_N",
			"pNR2B_N",
			"pPKCAB_N",
			"pRSK_N",
			"AKT_N",
			"BRAF_N",
			"CAMKII_N",
			"CREB_N",
			"ELK_N",
			"ERK_N",
			"GSK3B_N",
			"JNK_N",
			"MEK_N",
			"TRKA_N",
			"RSK_N",
			"APP_N",
			"Bcatenin_N",
			"SOD1_N",
			"MTOR_N",
			"P38_N",
			"pMTOR_N",
			"DSCR1_N",
			"AMPKA_N",
			"NR2B_N",
			"pNUMB_N",
			"RAPTOR_N",
			"TIAM1_N",
			"pP70S6_N",
			"NUMB_N",
			"P70S6_N",
			"pGSK3B_N",
			"pPKCG_N",
			"CDK5_N",
			"S6_N",
			"ADARB1_N",
			"AcetylH3K9_N",
			"RRP1_N",
			"BAX_N",
			"ARC_N",
			"ERBB4_N",
			"nNOS_N",
			"Tau_N",
			"GFAP_N",
			"GluR3_N",
			"GluR4_N",
			"IL1B_N",
			"P3525_N",
			"pCASP9_N",
			"PSD95_N",
			"SNCA_N",
			"Ubiquitin_N",
			"pGSK3B_Tyr216_N",
			"SHH_N",
			"BAD_N",
			"BCL2_N",
			"pS6_N",
			"pCFOS_N",
			"SYP_N",
			"H3AcK18_N",
			"EGR1_N",
			"H3MeK4_N",
			"CaNA_N",
			"Genotype",
			"Treatment",
			"Behavior",
			"class"
#endif
#if (datasource == "jessicali9530/honey-production")
			"state",
			"numcol",
			"yieldpercol",
			"totalprod",
			"stocks",
			"priceperlb",
			"prodvalue",
			"year"
#endif
#if (datasource == "unitednations/global-commodity-trade-statistics")
			"country_or_area",
			"year",
			"comm_code",
			"commodity",
			"flow",
			"trade_usd",
			"weight_kg",
			"quantity_name",
			"quantity",
			"category"
#endif
#if (datasource == "goldenoakresearch/us-acs-mortgage-equity-loans-rent-statistics")
			"UID",
			"BLOCKID",
			"SUMLEVEL",
			"COUNTYID",
			"STATEID",
			"state",
			"state_ab",
			"city",
			"place",
			"type",
			"primary",
			"zip_code",
			"area_code",
			"lat",
			"lng",
			"ALand",
			"AWater",
			"pop",
			"male_pop",
			"female_pop",
			"rent_mean",
			"rent_median",
			"rent_stdev",
			"rent_sample_weight",
			"rent_samples",
			"rent_gt_10",
			"rent_gt_15",
			"rent_gt_20",
			"rent_gt_25",
			"rent_gt_30",
			"rent_gt_35",
			"rent_gt_40",
			"rent_gt_50",
			"universe_samples",
			"used_samples",
			"hi_mean",
			"hi_median",
			"hi_stdev",
			"hi_sample_weight",
			"hi_samples",
			"family_mean",
			"family_median",
			"family_stdev",
			"family_sample_weight",
			"family_samples",
			"hc_mortgage_mean",
			"hc_mortgage_median",
			"hc_mortgage_stdev",
			"hc_mortgage_sample_weight",
			"hc_mortgage_samples",
			"hc_mean",
			"hc_median",
			"hc_stdev",
			"hc_samples",
			"hc_sample_weight",
			"home_equity_second_mortgage",
			"second_mortgage",
			"home_equity",
			"debt",
			"second_mortgage_cdf",
			"home_equity_cdf",
			"debt_cdf",
			"hs_degree",
			"hs_degree_male",
			"hs_degree_female",
			"male_age_mean",
			"male_age_median",
			"male_age_stdev",
			"male_age_sample_weight",
			"male_age_samples",
			"female_age_mean",
			"female_age_median",
			"female_age_stdev",
			"female_age_sample_weight",
			"female_age_samples",
			"pct_own",
			"married",
			"married_snp",
			"separated",
			"divorced"
#endif
#if (datasource == "ainslie/usda-wasde-monthly-corn-soybean-projections")

#endif
#if (datasource == "vikasg/russian-troll-tweets")
			"user_id",
			"user_key",
			"created_at",
			"created_str",
			"retweet_count",
			"retweeted",
			"favorite_count",
			"text",
			"tweet_id",
			"source",
			"hashtags",
			"expanded_urls",
			"posted",
			"mentions",
			"retweeted_status_id",
			"in_reply_to_status_id"
#endif

            };
            LearningPipeline pipeline = new LearningPipeline
            {
                new TextLoader<Fact>("./datasource/source.csv", useHeader: true, separator: "comma"),
                //Add Categorical Column Transformation
//FACT_STRING_COLUMN
                
                new ColumnConcatenator("Features", Columns),
                
                new StochasticDualCoordinateAscentClassifier(),

            };
            var model = pipeline.Train<Fact, Output>();
            var result = model.Predict(
                new Fact
                {
                    //Include Your Fact Dimensions Here;
                }
            );

        }
    }
}
