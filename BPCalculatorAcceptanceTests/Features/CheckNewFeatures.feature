Feature: SpecFlowFeature1
	Simple calculator for adding two numbers


Scenario Outline: Check All Catagory details
	Given is on the Blood Pressure Calcultor Page
	And the user enters <Systolic> in the Systolic field on the Blood Pressure Calcultor Page
	And the user enters <Diastolic> in the Diastolic field on the Blood Pressure Calcultor Page
	And the user enters <Age> in the Age field on the Blood Pressure Calcultor Page
	When the clicks on the submit button on the Blood Pressure Calcultor Page
	Then the result <Result> will be diplayed on the Blood Pressure Calcultor Page
	Then the Mean Arterial Pressure result <MAPmessage> will be diplayed on the Blood Pressure Calcultor Page
	Then the Pulse Pressure result <PPmessage> will be diplayed on the Blood Pressure Calcultor Page
	Then the Age Range result <ARmessage> will be diplayed on the Blood Pressure Calcultor Page


	Examples: 
    | Systolic	| Diastolic |	Age	|		Result					|		MAPmessage					|		PPmessage		|					ARmessage									|
    |    70		|   40		|   16	|	Low Blood Pressure			|	Mean Arterial Pressure: 96		|	Pulse Pressure: 31	|	Average value for your age group [15-19] is 120/78			|
    |    100	|   50		|   27	|	Ideal Blood Pressur			|	Mean Arterial Pressure: 133		|	Pulse Pressure: 51	|	Average value for your age group [25-29] is 121/80			|
	|    140	|   85		|   44	|	Pre-High Blood Pressure		|	Mean Arterial Pressure: 196		|	Pulse Pressure: 56	|	Average value for your age group [40-44] is 125/83			|
	|    170	|   100		|   88	|	High Blood Pressure			|	Mean Arterial Pressure: 236		|	Pulse Pressure: 71	|	Average value for your age group [60 and over] is 135/88	|