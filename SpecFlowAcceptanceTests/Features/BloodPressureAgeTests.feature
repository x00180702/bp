Feature: Acceptance Test for new featurea

@mytag
Scenario Outline: Check new features 
	Given user enters <Systolic> in Systolic 
	And user enters <Diastolic> in Diastolic
	And user enters <Age> in Age
	And Age range should be <AgeGroup>



Examples: 
    | Systolic	| Diastolic |	Age	|	Result		|	AgeGroup	|
    |    70		|   59		|   15	|	Low			|	AgeGroup1	|
    |    119	|   60		|   20 	|	Ideal		|	AgeGroup2	|
	|    121	|   89		|   25	|	PreHigh		|	AgeGroup3	|
	|    190	|   90		|   30 	|	High		|	AgeGroup4	|
	|    195	|   101		|   35	|	NotValid	|	AgeGroup5	|
	|    70		|   59		|   40	|	Low			|	AgeGroup6	|
    |    119	|   60		|   45 	|	Ideal		|	AgeGroup7	|
	|    121	|   89		|   50	|	PreHigh		|	AgeGroup8	|
	|    190	|   90		|   55 	|	High		|	AgeGroup9	|
	|    195	|   101		|   60	|	NotValid	|	AgeGroup10	|