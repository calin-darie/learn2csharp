Feature: CaesarPlus
	In order to encrypt the content of my files
	As a secretive man
	I want to use an encryption algorithm which increments every letter of the string by one

@encrypt
Scenario Outline: Encryption of text
	Given A file is located at <inputPath>
	And the file contains <text>
	When encrypted with CaesarPlus to <outputPath>
	Then the text in the <outputPath> should be <encrypted>

	Examples: 
	| inputPath                                        | text                                                              | outputPath                                        | encrypted                                                         |
	| C:\Temp\CaesarTests\Encrypt\emptyInputTest.txt   |                                                                   | C:\Temp\CaesarTests\Encrypt\emptyOutputTest.txt   | Error: input is null or empty                                     |
	| C:\Temp\CaesarTests\Encrypt\exampleInputTest.txt | This is a test for encryption. It uses the Caesar Plus algorithm! | C:\Temp\CaesarTests\Encrypt\exampleOutputTest.txt | Uijt!jt!b!uftu!gps!fodszqujpo/!Ju!vtft!uif!Dbftbs!Qmvt!bmhpsjuin" |

@decrypt
Scenario Outline: Decryption of text
	Given A file is located at <inputPath>
	And the file contains <text>
	When decrypted with CaesarPlus to <outputPath>
	Then the text in the <outputPath> should be <decrypted>
	
	Examples: 
	| inputPath                                        | text                                                              | outputPath                                        | decrypted                                                         |
	| C:\Temp\CaesarTests\Decrypt\emptyInputTest.txt   |                                                                   | C:\Temp\CaesarTests\Decrypt\emptyOutputTest.txt   | Error: input is null or empty                                     |
	| C:\Temp\CaesarTests\Decrypt\exampleInputTest.txt | Uijt!jt!b!uftu!gps!efdszqujpo/!Ju!vtft!uif!Dbftbs!Qmvt!bmhpsjuin" | C:\Temp\CaesarTests\Decrypt\exampleOutputTest.txt | This is a test for decryption. It uses the Caesar Plus algorithm! |


@encrypt
Scenario Outline: Encryption of multi-line text
	Given A file is located at <inputPath> 
	And the file contains:
	  """
	  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vitae gravida purus. Nunc 
	  quis nunc tellus. Cras laoreet congue urna, sed bibendum felis tincidunt vel. Donec ut justo sapien. Maecenas vel ligula 
	  odio. Suspendisse enim diam, malesuada ut velit nec, feugiat egestas turpis. Fusce non facilisis nibh, eu tincidunt mi. 
	  
	  Aenean convallis odio euismod, dapibus urna tempor, pretium libero. Praesent pulvinar, nibh et volutpat varius, felis sem 
	  ultricies nibh, sit amet rhoncus elit lorem sit amet leo. Fusce sed porttitor ligula. Pellentesque ut dictum diam. 
	  
	  Maecenas accumsan ligula arcu, nec bibendum risus finibus sed.
	  """
	When encrypted with CaesarPlus to <outputPath>
	Then the text in the <outputPath> should be <encrypted>

	Examples: 
	| inputPath                                          | outputPath                                          | encrypted                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
	| C:\Temp\CaesarTests\Encrypt\multiLineInputTest.txt | C:\Temp\CaesarTests\Encrypt\multiLineOutputTest.txt | Mpsfn!jqtvn!epmps!tju!bnfu-!dpotfdufuvs!bejqjtdjoh!fmju/!Wjwbnvt!wjubf!hsbwjeb!qvsvt/!Ovod!rvjt!ovod!ufmmvt/!Dsbt!mbpsffu!dpohvf!vsob-!tfe!cjcfoevn!gfmjt!ujodjevou!wfm/!Epofd!vu!kvtup!tbqjfo/!Nbfdfobt!wfm!mjhvmb!pejp/!Tvtqfoejttf!fojn!ejbn-!nbmftvbeb!vu!wfmju!ofd-!gfvhjbu!fhftubt!uvsqjt/!Gvtdf!opo!gbdjmjtjt!ojci-!fv!ujodjevou!nj/!Bfofbo!dpowbmmjt!pejp!fvjtnpe-!ebqjcvt!vsob!ufnqps-!qsfujvn!mjcfsp/!Qsbftfou!qvmwjobs-!ojci!fu!wpmvuqbu!wbsjvt-!gfmjt!tfn!vmusjdjft!ojci-!tju!bnfu!sipodvt!fmju!mpsfn!tju!bnfu!mfp/!Gvtdf!tfe!qpsuujups!mjhvmb/!Qfmmfouftrvf!vu!ejduvn!ejbn/!Nbfdfobt!bddvntbo!mjhvmb!bsdv-!ofd!cjcfoevn!sjtvt!gjojcvt!tfe/ |


@decrypt
Scenario Outline: Decryption of multi-line text
	Given A file is located at <inputPath> 
	And the file contains MptuEftpmbuf!boe!mpofBmm!ojhiu!mpoh!po!uif!mblfXifsf!gph!usbjmt!boe!njtu!dsffqt-Uif!xijtumf!pg!b!cpbuDbmmt!boe!dsjft!vofoejohmz-Mjlf!tpnf!mptu!dijmeJo!ufbst!boe!uspvcmfIvoujoh!uif!ibscps(t!csfbtuBoe!uif!ibscps(t!fzft/Dbsm!Tboecvsh-!2989!.!2:78
	When decrypted with CaesarPlus to <outputPath>
	Then the text in the <outputPath> should be:
	"""
	Lost
	
	Desolate and lone
	All night long on the lake
	Where fog trails and mist creeps,
	The whistle of a boat
	Calls and cries unendingly,
	Like some lost child
	In tears and trouble
	Hunting the harbor's breast
	And the harbor's eyes.
	
	Carl Sandburg, 1878 - 1967
	"""

	Examples: 
	| inputPath                                          | outputPath                                          |
	| C:\Temp\CaesarTests\Decrypt\multiLineInputTest.txt | C:\Temp\CaesarTests\Decrypt\multiLineOutputTest.txt |
