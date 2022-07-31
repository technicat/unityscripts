﻿using UnityEngine;
using System.Collections;

namespace Fugu {
	public class Words : MonoBehaviour {



	static public string[][] English = 
		{
		 //	[
		 //	"a"
		 //	],
			new string[]{
		 "an","as","at","ad",
		 "be","by",
		 "do",
		 "go",
		 "he",
		 "is","it","if","in","id",
		 "lo",
		 "me","my",
		 "no",
		 "on","of","or",
		 "pi",
		 "so",
		 "to",
		 "we"
			},
			new string[]{
		 "ant","and",
		 "art","arc","ark","arm",
		 "asp","ass",
		 "amp",
		 "ape","apt",
		 "age","ago",
		 "ate",
		 "add","ado","ade",
		 "ave",
		 "awl","awe","awa",
		 "aye",
		 "all","ale",
		 "ail","aim","air",
		 "bit","bin","big","bib","bid",
		 "but","bun","bug","bus",
		 "bat","bay","bar","ban","bag","bah",
		 "bee","beg","bet","bed",
		 "bog","boy","bob","bop","bow",
		 "bye",
		 "cat","cap","can","cam","cay","cab","cad","car",
		 "cot","cog","cop","con","cob","cod","coy","coo","cow",
		 "cut","cup","cud","cub","cue","cur",
		 "chi",
		 "dog","dot","don",
		 "dab","day","dam",
		 "dip","din","dig","dim","die",
		 "dug","due","duo","dub",
		 "dye",
		 "dry",
		 "eel",
		 "eye",
		 "ear","eat","eta",
		 "eon",
		 "egg",
		 "ell",
		 "end",
		 "ebb",
		 "era","err","ere",
		 "fur","fun",
		 "fog","foe","for",
		 "fee","few","fed",
		 "fan","fat","far","fad",
		 "flu",
		 "fry","fro",
		 "gay","gal","gag","gap","gab","gas",
		 "gig","gin",
		 "gel","get","gem",
		 "got","goo","gob","god",
		 "gut","gum","gun","guy",
		 "hoe","hot","hog","hop","how",
		 "hat","ham","has","hay","hag","had",
		 "hem","hew","her",
		 "hip","hit","him","hid","his",
		 "ill","ilk",
		 "imp",
		 "inn",
		 "ion",
		 "ire","irk",
		 "its",
		 "ids",
		 "ick",
		 "keg",
		 "kin","kit","kid",
		 "jot","job","jog","joy",
		 "jam","jab","jar","jaw",
		 "jet",
		 "jug",
		 "jib","jig",
		 "lat","lab","lam","lap","lag",
		 "lee","let","leg",
		 "lie","lit","lip","lid",
		 "lot","loo","lop","lob",
		 "lug",
		 "lye",
		 "mop","mob","mow","maw",
		 "mug","mud","mum",
		 "mar","mat","man","may","map","mad",
		 "men","met",
		 "net",
		 "nob","not",
		 "nip","nit","nil",
		 "nay","nag","nah",
		 "nub","nut",
		 "out","our",
		 "obi",
		 "oil",
		 "oat","oar",
		 "odd","ode",
		 "one",
		 "own","owl",
		 "pup","pun","put","pus","pug",
		 "pop","pot","poi",
		 "pip","pit","pig","pin","pie",
		 "pep","pet","per","pee","pen","peg","pew",
		 "pat","par","pan","pal","pay","paw","pas",
		 "psi",
		 "rat","rag","ram","rap","raw","ray","ran",
		 "rug","run","rub","rut","rue",
		 "rig","rib","rid","rim","rip",
		 "rye",
		 "rho",
		 "rot","rob","rod",
		 "sit","sip","sin","sic","six",
		 "sat","sap","say","sag","saw","sad","sac",
		 "sot","soy","sop",
		 "sum","sun","sup",
		 "sty",
		 "tan","tar","tap","tag","tad",
		 "ten","tee","tea",
		 "the",
		 "tin","tip","tie",
		 "top","toy","ton","too",
		 "try",
		 "two",
		 "tug",
		 "ugh",
		 "urn",
		 "vie",
		 "vet","vee",
		 "way","war","wag","wad","wan","was",
		 "win","wit","wig",
		 "woo","woe","won",
		 "wee","wet",
		 "who","why",
		 "wye",
		 "wry",
		 "yes",
		 "yar","yam","yay",
		 "yip",
		 "zoo",
		 "zap","zag",
		 "zit","zig","zip",
		 "zee"
			},
			new string[]{
		 "abet",
		 "arid",
		 "amid",
		 "alit","ally","alas","aloe",
		 "anon",
		 "agog",
		 "awry","away",
		 "barn","bake","bark","bank",
		 "beet","best","bend","bent","belt",
		 "body","bode","bold","bone","boat",
		 "burp","bust","bull","bulk",
		 "brie",
		 "bill","bile","bite","bide","bike",
		 "card","cart","carp","cast","call",
		 "cede","cent","cell",
		 "clad","clay","clap","clot","clip","clue","clan",
		 "cost","cold","coke","cone","cope","coat","comb","cool","coop","coon",
		 "curd","cull","cusp","cuss",
		 "crud","crap","crow","craw",
		 "deal","deer","deep","dent","deny",
		 "dare","dale","dank","dart","damn","darn","dang","dame","date",
		 "door","dolt","dork","dole","doll","dose","dove","done","dope","doze",
		 "dude","dust","dupe","duke","dune","dump","duck",
		 "dirt","dire","dirk",
		 "dice","dine","dial","diva","dive","dill",
		 "dish","disc","disk",
		 "drab","dray","drop","drip","drag","drug",
		 "eave","east","ease",
		 "even","ever","evil",
		 "exit",
		 "fine","fill","file","find","fire","five","fish",
		 "fail","fade","fast","fart","fall","fate","fare","fame",
		 "feed","fest","feel","felt",
		 "fool","food","foot","foal","four","fold","foam","fort","fore",
		 "fuel","fuse",
		 "flit","flat","flow","floe","flaw","flew","flay","flag","fled","flee","flea",
		 "fret","free",
		 "grab","grub","grin","grow","grog",
		 "gale","game","gate","gaze","gain","gasp","gash","gaol","garb",
		 "gird","girl","gist","gild",
		 "gosh","goal","gone","goat","goad","good","goon",
		 "gush",
		 "glad","glue","glow",
		 "hush",
		 "hash","hail","hale","halt","hair","hate",
		 "hemp","heal","heel","hear","heed",
		 "hoof","hood","hoot","home","hole","hone","hope","hook",
		 "hive","hike","hide","hill",
		 "hype",
		 "itch",
		 "jump","juke",
		 "joke","jolt",
		 "jail",
		 "jive",
		 "kill","kite","kind","kilt",
		 "kale",
		 "love","loaf","lost","lone","loan","lore","lode","lose",
		 "lame","late","lamp","last","lard",
		 "line","live","list","lint","lick","lisp",
		 "lust","lurk",
		 "must","muse","mute",
		 "made","mast","male","mail","maze","mate","mane","main",
		 "more","moot","moon","mope","move","most","moor","moss",
		 "meet","mend","meal",
		 "mist","mine","mire","mile","mint","mink",
		 "nice","nine",
		 "nail","name",
		 "nose","none","nope","node",
		 "null",
		 "obey",
		 "oven","over",
		 "once","onto",
		 "ogre",
		 "open",
		 "poor","pool","pose","post","poet","port","pole","poke",
		 "pace","pain","pale","pail","pair","page","past","pact","pant",
		 "peer","peel","peen","pest","peat","pear",
		 "pill","pike","pile","pine","pipe","pint",
		 "pray","prod",
		 "play","pled",
		 "pure","puke","puce",
		 "pyre",
		 "quit",
		 "rail","raid","rape","rage","rant","rack",
		 "rude","rust","runt",
		 "rope","rove",
		 "risk","rive",
		 "same","said","sail","sate","save","sake",
		 "some","sore","soap","soon","soot",
		 "sire","site","sill","sift",
		 "sled","slit","slat","slop","slap","slid","slot",
		 "seal","seer","seep","seed","seen","seek","seem",
		 "skit","skid","skip",
		 "scat","scad","scot",
		 "stun","step","stop","stir",
		 "spat","spec","spit",
		 "shed","shoo","shoe","shop",
		 "surf","sulk","sump",
		 "tire","time","tide","till",
		 "tyke",
		 "tame","tail","tape","task","tart","tarp",
		 "them","they","that",
		 "toon","tool","toot","tort","toss","toll","toil","toga",
		 "trot","tray","trap","tree",
		 "test","teal","teak","tear","teen","team",
		 "urge","unto","undo",
		 "veer","vest",
		 "vale","vast","vain","vane",
		 "vine",
		 "vote","vole",
		 "wait","wail","waif",
		 "walk",
		 "want","wane",
		 "warm","warn","wart","ware","ward","warp",
		 "wash",
		 "wave",
		 "weed","west","wear","weak","wean","weal","well","weld",
		 "when","what","whet",
		 "whit","whim","whip",
		 "wine","wind","wing","wino",
		 "will","wily","wile","wild",
		 "wish","wise","wisp",
		 "wire",
		 "wife",
		 "with",
		 "wimp",
		 "wood","woof","wore","wove","wool",
		 "year",
		 "yore","yolk","yoni","your","yowl","yoke","yoho",
		 "zarf",
		 "zest","zeal",
		 "zoom","zonk","zone","zouk"
			},
			new string[]{
		 "after","afore",
		 "album","alter","aloud","alone","alert",
		 "agent","agate","agile",
		 "ardor",
		 "aster",
		 "atoll","atone","atlas",
		 "amend",
		 "anull","anode",
		 "baste",
		 "boner",
		 "bevel",
		 "broke","brash","brake","brute","brave","brown","brisk","brink","brain",
		 "biker","birch","binge",
		 "buggy","bunny",
		 "caulk","cater","caper",
		 "cover","coven","coast",
		 "crate","crave","crane","craze","crazy","cramp","crass","crash","cross",
		 "clasp","clash","clone","cloak","clock","clown","cloud",
		 "chart","champ","chair","chafe","chalk",
		 "chore","chose","choke",
		 "diner","diver","dirge","dizzy","divvy","dippy",
		 "drive","drink","drill",
		 "drake","drape","drank",
		 "droll","drool","dross","drove","drone",
		 "dreck","dread",
		 "dunce",
		 "dance","dairy","daisy",
		 "devil","demon","death","dealt",
		 "donor",
		 "easel",
		 "ebony",
		 "eight",
		 "elegy","elude","elate","elide",
		 "evade","event","every",
		 "enema","enemy","enter",
		 "epoch",
		 "feast","fever","felon",
		 "fatal","fader","favor","farce",
		 "floss","flock","flood","float",
		 "flash","flack","flare",
		 "flick","flint",
		 "fluff",
		 "fight","first","filch",
		 "fjord",
		 "futon","furor",
		 "frost",
		 "forth","foray","forge",
		 "goner","gorge","goose",
		 "glaze","glare","glass",
		 "ghoul","ghost",
		 "gator","gamer",
		 "grape","grain","grail","grasp","grate","grant",
		 "growl","grope","groan","gross",
		 "green","greed",
		 "grist","grill","grind",
		 "gruel","grunt",
		 "guilt","guile",
		 "haven","hater","hatch","haunt",
		 "horse","hoist","hooch","hover",
		 "juice","joint","joist","joust","jowly",
		 "leper","leave",
		 "livid","liver",
		 "loser","loner",
		 "miner","mince","minor","miter","mirth","misty",
		 "moist","moose","mooch","motor","moron","moldy",
		 "match","march","mange","mangy","maxim","major","maker","manor",
		 "metal","melon","medal","meaty",
		 "mulch",
		 "nasal","naval","navel","natal",
		 "nodal","noise","noose","north",
		 "never",
		 "often","offal","offer",
		 "peace","peter","peeve","pesky","peppy","penny",
		 "piper","piker","piton","pitch","pinch","piece",
		 "poser","posse","pooch","poker","point","porch",
		 "paint","paste","patch",
		 "phase",
		 "plead","plaid",
		 "purge","puppy",
		 "quest","queer","quill","query",
		 "raven","razor","radar","radix",
		 "riven","rigid","rigor",
		 "roast","roger","rotor",
		 "ruddy","rusty",
		 "sally","savor","salty",
		 "sofit",
		 "sport","spurt","spite","spire","spare","spate","spoke","speak","spill",
		 "smart","smile","smirk","smoke",
		 "snick","snack","snore","snare","sneer",
		 "surge","super",
		 "sewer","seven","sever","sepia","sense",
		 "slurp","sleep","slash","slave","sleek","slope",
		 "steal","steer","steep","steed",
		 "store","stoop","stock","stomp","stole",
		 "stare","stair","stake","stash","stack","stall","stalk",
		 "stiff","stint","stick","stilt",
		 "skiff","skate","skill",
		 "sheen","sheep","sheik","shell",
		 "shale","shake","shape","shaft","share","shame","shack","sharp",
		 "shore","shock","shone",
		 "shine","shift","shirk","shill",
		 "silly",
		 "score","scold","scape","scale","scare","scoop",
		 "south",
		 "taper","taser","taste","taint","taunt",
		 "tease","tepid","teeth",
		 "timid","tithe",
		 "there","those","these","their",
		 "tooth","touch","torch","toast",
		 "tread","treat",
		 "train","trail","trade",
		 "troop",
		 "trite",
		 "truce","truck",
		 "twist","twirl",
		 "under",
		 "usher",
		 "ulcer",
		 "vomit",
		 "venom","venal",
		 "vapid","vapor","valid",
		 "vigor","vital",
		 "water","wafer","waste","waver","wager","wagon","watch",
		 "welch","wench",
		 "windy","wimpy","wierd","wince","witch",
		 "wheel","where",
		 "wharf","whale",
		 "whose","whore","whole",
		 "white","whore","whine","whiny","while","which",
		 "wrist","wring",
		 "yodel","yours","yokel",
		 "zonal","zooid"
			},
				new string[]{
		 "ablate",
		 "aghast",
		 "advent",
		 "affirm",
		 "amount",
		 "annual","answer","anthem","antler","analog",
		 "apogee",
		 "archer","arctic","artist",
		 "assent","ascent",
		 "attain","attach",
		 "avenue","avatar",
		 "ballet","banter","bauble","babble","barren","ballot","banner",
		 "berate","beside","bellow",
		 "billet","billow",
		 "bounce","bottle","boggle","borrow",
		 "breach","broach","branch","breast","brunch","braise",
		 "bubble","bubbly","burble","bundle","bungle","burgle","burden",
		 "crotch","crouch",
		 "dancer","damper","dabble",
		 "denude","deride","decide","debtor",
		 "dinner",
		 "double",
		 "egress","energy",
		 "faster","fallow","fallen","falter",
		 "fealty","fervor","fester","fender","fellow",
		 "future",
		 "fillet","filter",
		 "flange",
		 "follow",
		 "garrot","gallow",
		 "gentle",
		 "glance","glamor",
		 "gullet",
		 "grouse","grudge","grunge",
		 "halter",
		 "height",
		 "hollow","hogtie","hoagie",
		 "lancer","lancet","lampas","lampad",
		 "limpid","liquid",
		 "marble","martyr","master","mantle","manner",
		 "mental",
		 "mister","mildew","minnow",
		 "morale","morose",
		 "mystic","mortar",
		 "murder","muster",
		 "orator",
		 "parrot","parade","pallet","palate","patter",
		 "penury",
		 "pillow","pillar","piston","pistol","pincer",
		 "planet","please","plunge","plight",
		 "poster","pounce",
		 "purple","putter",
		 "roadie","robber",
		 "rubber","rubric",
		 "sallow","scorch","scotch",
		 "slouch","snatch","sprint","sketch","supper",
		 "stitch","starch","statin",
		 "syzygy",
		 "tamper","tallow",
		 "temper","tender",
		 "trader","trance","trudge",
		 "violet",
		 "weight","weasel",
		 "willow","winner","winnow","wigwam",
		 "wallet","wallow",
		 "wretch","wrench",
		 "yellow",
		 "zipper"
			},
					new string[]{
		 "abstain",
		 "adulate",
		 "affront",
		 "agitate",
		 "amorous",
		 "analyze","analogy",
		 "athlete","attempt",
		 "ballast",
		 "biology",
		 "collect","collate",
		 "cogitate",
		 "convent","connect","convect","convict","consort","contact","content","consent",
		 "courage",
		 "density",
		 "dentist","dentate","decorum",
		 "diorama",
		 "educate",
		 "empathy","emulate","eminent","emirate",
		 "explore",
		 "feature",
		 "fluster",
		 "fulcrum",
		 "gallant",
		 "gelatin","geology","genuine","gentile","genteel","gestate",
		 "glimmer","glisten","glitter",
		 "gourmet",
		 "gymnast",
		 "hickory",
		 "hostile",
		 "imagery","imitate","iminent",
		 "manners","majesty",
		 "mystery",
		 "nirvana",
		 "nurture","nunnery",
		 "odorous",
		 "ominous",
		 "opulent",
		 "ovulate",
		 "perturb","perjury",
		 "pillage","pillory",
		 "placate",
		 "sleight","strange","scourge","splurge","scratch","stealth","suicide",
		 "traipse","travail","trigger","trounce",
		 "village","villain","violate","violent"
			},
						new string[]{
		 "abrogate","abdicate",
		 "alacrity",
		 "audacity",
		 "capacity",
		 "distinct","district",
		 "genocide","generate",
		 "gourmand",
		 "homicide",
		 "impudent",
		 "instinct",
		 "melanoma",
		 "mitigate",
		 "pacifist",
		 "parasite","paralyze",
		 "polarize",
		 "salivate",
		 "sympathy",
		 "travesty",
		 "venerate","vegetate",
		 "violence"
			},
							new string[]{
		 "adenosine",
		 "aggregate",
		 "astronomy",
		 "cognizent",
		 "communism",
		 "continent","conscious","consumate",
		 "correlate","corrugate",
		 "democracy",
		 "elucidate",
		 "garrulous","galvanize",
		 "imperious","impatient","impetuous",
		 "intuitive",
		 "melodrama",
		 "motorcade",
		 "oligarchy",
		 "pathology","patronize",
		 "phosphate",
		 "pomposity",
		 "potentate",
		 "postulate",
		 "salacious",
		 "socialism"
			},
								new string[]{
		 "accentuate",
		 "aquamarine",
		 "compliment","complement",
		 "fraternize",
		 "gastronomy",
		 "generosity",
		 "gregarious",
		 "paraphrase",
		 "plutocracy"
			},
									new string[]{
		 "constituent",
		 "gerrymander",
		 "interrogate","instinctive"
			}
		};
}
}