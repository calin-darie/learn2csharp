Feature: CaesarMinus
	In order to encrypt the content of my files
	As a secretive man
	I want to use an encryption algorithm which decrements every letter of the string by one

@encrypt
Scenario Outline: Encryption of text
	Given The file contains <text>
	When I encrypt with CaesarMinus
	Then the text should be <encrypted>

	Examples: 
	| text                                                                                       | encrypted                                                                                  |
	|                                                                                            | Error: input is null or empty                                                              |
	| abcdef                                                                                     | `abcde                                                                                     |
	| "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{ | !"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz |
	| This is a test for encryption. It uses the Caesar Minus algorithm.                         | Sghrhr`sdrsenqdmbqxoshnm-HstrdrsgdB`dr`qLhmtr`kfnqhsgl-									  |


@decrypt
Scenario Outline: Decryption of text
	Given The file contains <text>
	When I decrypt with CaesarMinus
	Then the text should be <encrypted>

	Examples: 
	| text                                                                                       | encrypted                                                                                  |
	|                                                                                            | Error: input is null or empty                                                              |
	| `abcde                                                                                     | abcdef                                                                                     |
	| !"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz | "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{ |
	| Sghrhr`sdrsenqdmbqxoshnm-HstrdrsgdB`dr`qLhmtr`kfnqhsgl-									 | This is a test for encryption. It uses the Caesar Minus algorithm.                         |


@encrypt
Scenario: Encryption of multi-line text
	Given The file contains:
	  """
	  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vitae gravida purus. Nunc 
	  quis nunc tellus. Cras laoreet congue urna, sed bibendum felis tincidunt vel. Donec ut justo sapien. Maecenas vel ligula 
	  odio. Suspendisse enim diam, malesuada ut velit nec, feugiat egestas turpis. Fusce non facilisis nibh, eu tincidunt mi. 
	  
	  Aenean convallis odio euismod, dapibus urna tempor, pretium libero. Praesent pulvinar, nibh et volutpat varius, felis sem 
	  ultricies nibh, sit amet rhoncus elit lorem sit amet leo. Fusce sed porttitor ligula. Pellentesque ut dictum diam. 
	  
	  Maecenas accumsan ligula arcu, nec bibendum risus finibus sed.
	  """
	When I encrypt with CaesarMinus
	Then the text should be Knqdlhortlcnknqrhs`lds+bnmrdbsdstq`chohrbhmfdkhs-Uhu`ltruhs`dfq`uhc`otqtr-Mtmb	pthrmtmbsdkktr-Bq`rk`nqddsbnmftdtqm`+rdcahadmctledkhrshmbhctmsudk-Cnmdbtsitrsnr`ohdm-L`dbdm`rudkkhftk`	nchn-Rtrodmchrrddmhlch`l+l`kdrt`c`tsudkhsmdb+edtfh`sdfdrs`rstqohr-Etrbdmnme`bhkhrhrmhag+dtshmbhctmslh-		@dmd`mbnmu`kkhrnchndthrlnc+c`ohatrtqm`sdlonq+oqdshtlkhadqn-Oq`drdmsotkuhm`q+mhagdsunktso`su`qhtr+edkhrrdl	tksqhbhdrmhag+rhs`ldsqgnmbtrdkhsknqdlrhs`ldskdn-Etrbdrdconqsshsnqkhftk`-Odkkdmsdrptdtschbstlch`l-		L`dbdm`r`bbtlr`mkhftk``qbt+mdbahadmctlqhrtrehmhatrrdc-

@decrypt
Scenario: Decryption of multi-line text
	Given The file contains Knrs		Cdrnk`sd`mcknmd	@kkmhfgsknmfnmsgdk`jd	Vgdqdenfsq`hkr`mclhrsbqddor+	Sgdvghrskdne`an`s	B`kkr`mcbqhdrtmdmchmfkx+	Khjdrnldknrsbghkc	Hmsd`qr`mcsqntakd	Gtmshmfsgdg`qanq&raqd`rs	@mcsgdg`qanq&rdxdr-		B`qkR`mcatqf+0767,0856
	When I decrypt with CaesarMinus
	Then the text should be:
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

