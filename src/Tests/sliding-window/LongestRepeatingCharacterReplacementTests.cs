﻿using NUnit.Framework;

using Problems;

[TestFixture]
public class LongestRepeatingCharacterReplacementTests
{
    [TestCase( "ABAB", 2, ExpectedResult = 4 )]
    [TestCase( "AABABBA", 1, ExpectedResult = 4 )]
    [TestCase
        (
          "GGUIVILPZJXWWZLVKETZWWFKDYCRQICLYYJDMRCQVCSFCSKRMKCFUNAECJVRLAIWFJADSNNYDPXVYGPNCLLCQ" +
          "JBAUVPTJCWEXATZVJVCPQWLZNUEIAUHYCBMFJSJJHPBNBFLKSGXQVQUBYFORKGFPPMIJNMSTBPPUBNYLKFAWD" +
          "HTWEJKHNLOCTJQUKOPSGOLVYUQVDKZNEHPLRVHNEXGRPFQXSUUPWASPCNMPLQLPTUWNFANSVUEOBXPTRRJEEV" +
          "IXEFUYRMTITPDNFYUVEMXZGMBTOLRWKHQQINSWGKVBDKUGQZSHFKPLQMVHUWMAVZGQJLTFHONMUSQUHZTQCKA" +
          "RLOXZETTQQNMKRNHIKOBUCMRGFSPZOIXTCLEKJOMMERVPKBLKATXOAUCAJNNFNZGROGOYCWUPWFSJXDYRIMLQ" +
          "ZRQQMEISASTXVZQJRLGIKGSAEPGJAIHKFJFVNPAGQVTWIHKWQTWIGSSDNAPSKXWSOSCKZDSELZYQJKABUDCJI" +
          "ZGNBBAEVFMKXOQLZLJSODTUJJRUGEAISYVSZIHNYFDULBMEDDRKXTFPTJWYIDEKUSVNFIVCOYCHKJNSKEJNAH" +
          "VZVVXKBSOYNXZVKKBJYBSNJXYTIDMJFWVGFVOVRDZSMKCIDZLAHEDXNBCZPJPZJNMEVYIMRQNPXVMEYCSJWGT" +
          "IGHGTCERQUCMBVRWPGMFEMWBUYCXBKNERVVRKOFCJEZUWUGYPKTVBTRBIOTZUZYSDNVJAFDRNVYKEWLONXAXD" +
          "SVRHXSMVPAJSXJNZFFQWMPEMHVVAYWIXHSFXZIZTCRCLDEPRWADXSDKTFVNWJWNIOERYVJDWRJXCJSSCTDJOF" +
          "HXVSNHXZCXQNGXDWXSEPRMROPGDJYGBCDPFZHSJLMHFREFYDXEGKGDVILPDLYTDAPGUYGGLAECDMTCATVRNQU" +
          "UKNTCYFBADMPGZJAIXNAMCPCCAKWKMRGKRUEQFXJRWHCXYXZPYLNGBSAAGBALUUUDMTSIBAIDVLBGWAPTPDGV" +
          "UZHUXXYPLYWWBAWNYOQCDOYDIRFOFZOXQTQAQUCOHUDMBVROXBDXZQGTMUJSMLGPBEJCEYTADSVVSIEKIOBYH" +
          "ZEODBSAIYZASOKFOVVILHFRDHRRFCTOBUSQXKVSGCAKZPBILKAIVEJDNKAVEMLCVLOMGPKPHOAVSOFQBAFCMX" +
          "JJJLMUVWOYBDMGBHZMUNEKEUWDCJAJRWNZQMSVRILFAQCUAQKDGENWPFBFSCETWDAQDNVLORCDEQENYPOILDW" +
          "PIPINNEJFOTFIXNLJYSZMEBBHMSOIHARKXZLEQVHKSNEFVBPDYTCXWUEKIZLRVTHAUNYAPLSDIMHVTZIPCSKW" +
          "HGMFHBYSTNZSWIRMBDRWPDINVIYTEELJHBNDBVAZENFHORYSUPJAOEKIHXSOVLZZCNEFXAHQMTAHMLNNHWBXK" +
          "RWWGZJTDTPSEMVVKGAWXSCJBOAWTNGIQRGODWOFCIQYCJANKCCJOELIIDQVRUIHUIQLWZSYHRENHXQGYKXRIN" +
          "PTBXGEUNYIBZPMENWVSVOFNNBLJHJUDDJTDQGXNABPCAAAINPFRIFNFGVQZURJMFGCCYIFNJYFVZQZIELQUUS" +
          "QTAAOOOIGBLPVOIQPLIZLQVXZGSWGQZUXQDRIBRFDGXRKAFYJWMUOANHKOBRMQVHVAEIVCRNQOAWPVBRRPZJQ" +
          "ZSDLAANATNGWLTJALQFREICUIXTFSTJAYHQVJBPHAJOMTPBWAGANDOSGIKFJIAFEGRSPWXCXPPARWSRNRZIOF" +
          "OMVNDLNNGCBVOOSPTFQQCNYDFXIZUBJUHHFZTYVKOXVDDRVICTXGCOZLBCKEHYAASGMWIBVZFIXOSQLUFXFMQ" +
          "DABVTAXJQILPYHTJQOSEANXYTVRYZWENFXTVPCZTXPOIYCYAOLQVYDBRMMNFTYKKMFXAISADZNIATGJAUUFRE" +
          "ZGOGDJGGVYFKYCTORORXZFETRKLMSSZBNPLXKHPTDWAPIRJGKSMWHWDVYEPCFTMWXEFNPQQRASGBEQZOLLIYH" +
          "VQDQWRBQWSHIKOBMXMLFOIPHAVILRXERYACNFYQIEIFNOEHLSQDTDBTAWDRJHMCTMDZLPEUJADTRTYGTFMNXX" +
          "EYLNEDIDCUVACLDIOCOAYXPTYATDMXRZPQDBHKVQGINNHKALPPVPDZBPMRKCBZEPTMWSYWQDGWYKAZPJORYLE" +
          "NUDLZBFWOJNVLCKJYJWRXGWWURULTXOKKCISJBHRMVCELQSOROWBYIGJUHSMMEMCROQCNEBGIPZTTOVDUXYXS" +
          "FPKBVNEHBMRKQNKUSXUSGJSTGJCDXZMVKGWJIRAKCUOYUEOKFRBJUMGWMUUTODTDMRCESDZHNJBAPZVGYBLBD" +
          "XKXAXIRPMWVOPVEVXLIGRYMPMREHLWRDIAYWDYQLDUNYUMYWFSAIIBDIUNRGPGKUSBAGHRUTGIVTPTFEGOSUP" +
          "NQLKETROUEAIEWEJBNCDBUGJSEGUSCXPBNJHLOHAALNCMSVKVUGCUWXPHEKAYKDJUYKBXMWIJRFQHOIFFVUIG" +
          "MUOZACQAVBXZBWRLJJNKJSNHGHETXMOPDRRWWXNPWXYADMOCNCUFSMXDEGPTHLZZOYBCOAEEVUFJXFOUYVQWB" +
          "PCSHIEBZWAZUUPAIXTTEREKYYTHNQUATTDNQFBBJIQDNAEXYPKRUSAEEVVCDAAXSMNXXDSPLWFVCZVUPKCFVN" +
          "YMGKYRVZFBDSLORQXWIUEYOFDOVWOPLZKFWQYOIYAEZRQZLQKIGFCGXDSKKSIKHBYDMWZUPBBDUPUCVYWHZIE" +
          "BYFQMJUWHPIOKWSMOSMXPBLFXVVLXMYKXKAEHCXLQWIYULQTNVIUTXTOKZROOXLULLCBSUEQKXVGBXHZDCZLK" +
          "WTOXNEWKKMLFUWQADDPCGTHCAOQAHXKLGXUKJDPTYZTASGQAFOYHJMIDXMOWWJFUAPBXBGJEZJXWTWWKWHRXA" +
          "ELXYJXFRTJJHOZWVDCETVPVQKAVYPMYNGRMIKKUYQCHHAKVQJVNRQRMNOQYFXGPCAACCRBYSWZLDVEMTEZNOE" +
          "SIDWOJQVQGHHBDEUMNFKSZFMBMTAMLFRZWOCJTWGSOWDUWBJSBEHOVGMMNSZNBFGOMNAGGPLGKWDDALFMXCOH" +
          "GHWKAGDOHBXVGRMRIJCRQFTMHAJEJKGIUDIKFGWGQSGKJBGOWZUVSJYYFCPAEJWNLWTGVQQPUYYEFFOZWXGWG" +
          "SRYDXPUZIVKHTTULABWWAKISZGTGSNUITQMTLJXOYCYBFPAVOUAMJLUCMRAGXTJQKXQFJIMOMXDXWQNJOPWSP" +
          "WXZMJVCSRNLZYAOOVDUVMOOIGKMRVADDRTQWTLMLPAFWSONDTIRPUAUAMPJUAZRLIHLGLUKOHXTLLDSGCQBZE" +
          "WVHTWTINAVDNULUAGNNGIVWDOMPHCDTPDVGJLYLSUMQQSVPHNAETDGGIOQPPOILSMDGTOQZBZZLEHNOZHZCEF" +
          "ITTMEEVGHFKGVUVRMSNEJNVTLVCRKIMKJBZHBJPJEDXBOFRLSAMCNEXPAFXVRUORPIFGAMWQPLTBGQLUBYIHE" +
          "PWSLPEGHAOEZFESFBCZQQMYRMFUCDZXPYYVOLGMHQZCCYPDGCQLIMJYHXWATYEVPOHUJDHJHZILPBOGJVBYUY" +
          "HTOCVVECOBZPWCLVCVMAUOGIKSEBLWYZQYCNPECVOKFSBIYTPHZTVPQTSDZXULAGZLGGHSSQOOZFNOFBPTENB" +
          "HVURGFBKXRGGUKFHGZIIEOAXMCGHJAZQMNRBHBOZWDXLAVMPFTRXSGHOHSEPRNNTAVYWSGNUUZFTOFYWBVEQV" +
          "KSBUXEUKPFICJDPLPAEVMKPNNTPAREICRASNVGLGFYYKRPCMMHPDOIZFIEFUGPUWTBUMFNHCEJJQQOKVGNDWD" +
          "HUOBYIYFIOFTRDHFIJDCXAWPZJZWXRFFVXSYGBSTFRFISCKIPDDXQLMROTOWMONTULAGYTOIIPPWFTCZSKXPP" +
          "KJGTTBTJHYFEHEDECISNZLRIGDUZPTAYSKDYEVVJGCTMRKUXVTHOIZZJAEULSVSHGXLGGVCZVTEBJIMFNVXEX" +
          "HBQPJILRPBCXCLXHDMWAHSYUIIWUXHNGLIILQEXDPJKDRRTLNPFAKORFUNIUQUNJBLZIXQRMUQBBWUSLUDDDV" +
          "PKAMNUPAGTSITEFWEHKYKANXHLKHHNBAXVRUNLFYBYNEFUVWGRFBIFIAJURNAYYXKGOBSRZRWCIWHUHQJYMKE" +
          "GLGCVRWHRRPFUKNNKRAEIIDSMUYXYKIMUOERIOVMLDUQIFGHENAQFHEPGKBKGTQGYOKZJDDXANCWFKRSRWAKU" +
          "NKKLGXTMUANEUSAELWDBRBLEZRMWBYONUQAHFBMWNDKCIXHTVMWKVLTCPZJTTJNIVDOSTOXHRGOQULDXYEWBE" +
          "COGSQHVVPLBTYXEFGWCDHFORQPLZVZPASYCDDDBYSERCZSRUGJKSPDEDQPPWVXHXYRHBVWFQTQEADIKBOSZIF" +
          "KWAEQQLEFLFUTRVNUWPZPPRBXUUHBVADNSJPUPIKVORQQSOYVLEHUDCJUVDMTQMRAKXDMIIDGTUAHHLCEJCTR" +
          "GZCAHIKCTFLZRTDMTFWQGIIVSOXPBQEQTOTQEMTMDNQCAONKUFQGHGYYANICAWWSLZJIICHYPLZOGCKOPBLJK" +
          "VJTLOGTPYQPYDVBBYECBUAFETGUOMGHYPMSNPDYQWVBMYGAKCPWLLIYXPOFRCFQDLWYMZFOCALQOBQWLTKFPG" +
          "KFXXGVPJOUFQOPBENFBJTZQRAHGPQAEUCVKCVFQSXZFYZFMSIRIXGCHBRXTVRCYMHBLMQRXCBPOZHIBUDIVNU" +
          "QCHQHHLJUKKFTYJCKGIUXNDTQHAJSLJQBJCVAQGYAOZZOOUGFZYBCECSHQOKYGTTIKSYLCCFAIAYLHEDIQSSB" +
          "GMYHSMQFZNGSDBNFORIXTKHRQVBIOHVLCEZCNRLBVJAJVUWAMJUMERWLDEZBABJQZSGROERFZBUSSLOVPUPTT" +
          "VHVOALEFSBPJILYTIJKCVPEFVOJHLSRBYPAQAICBVEAXHDRRJPMFSBVVZSIDSTTWQURBPAILAKFVZMCMFFZNM" +
          "HDFDOGOMOKAYNKYWMXWISGSZWVTABHXZGHCLBAGCPECGXLMOCGDUXATITPQJJNOGNTQVFLOLNBLQUSVWXDNWL" +
          "SWPQMVQAXQYTEJAOJGXNVQRUHCRVTZFBQTQIRUFAMFMZNZOLBZSPOOFCQNAQGMIKPNUVVNHPHHVQWKUMWMIIC" +
          "PYDXMQHKPAICYBBXGJYACQMJSJNJQTLCKKTXLKOQGRVXMMXAJWORYLTEHAQUOAHHWTXIFXIYNHKILIZKLGGTO" +
          "SDVDPXGVRSBAEQLNHFIKPSADHXUJZDWXYGPCHFHZPQRNFBOFVTFJGEWKFKGIMQUPQINJHOGNARVQCCFMCIQLY" +
          "CUGVEYBLOAZTCOFKQKEWWQIUVEJUMNWFTLNZNJDNTXUGRZLBPYCEXMKGQNUEARXQHNSKEOAXGKPNCKNRUHORV" +
          "HBYQOOKRGBSLYDVGCYZTSGJCNMZQGUBSFNQHDNWLUGWLSEGUTBGJVYMYLOOVRLJVZDLJSVFCFAMWYFWFYOKLY" +
          "JCTSYATNYLQXONMFHTDCHHFUOIJRUMBJCLIPLLTRYQUVQMGWEUZQYVDMPJAENUONSUNXLUSOBJIYPWTDPUWKC" +
          "GJFWPOUKIYUUXORYDGKNSGPBSPTAHHJUZCNOITUFNLCLCJFTYGKXQHAPTHTTBTJWBZDRBJTGUTCBJMIYVETCB" +
          "ZAHNVOILBJKYJYYCVKWWGQFLIKPECOKSEEMBDWRABXMGVBZQWFYCBFBUMKNALEOBDBKXOSQRQENKFFJHKUSKQ" +
          "PAPQEBKOLICBGOWRYTXQVMWODJBKMCJMRIIJIQLQLQZLQBBGVOYEVMZBDNTQWNWSMUNCOCYBJIMRNQZHQUEGH" +
          "AKGPSUFUGPIKLHDOZRCKZMLSPRWHXGUCFPTRLGIZZXVZWXBQHBHMRQWVUHPFREKFUZCUBEULVZLRZYVKLNXLY" +
          "HDRMIHDDSINVAOHTTPUJKLVNAAYJSPGODSNSANFITXTOZANRBLHQAEGRPDKZOBVXXEZYKMGHIHHESBMMHQEEO" +
          "OMCLRMTLHROLPBMKEVGMXXJADOFTIOBTRKZEMIEALBHWHMPTATKODYHTFULFCIBRDTZWZUFGWNGTCFZCYISAX" +
          "PUUSNCPFMEFIPYVWRXJUBLIJSFHAQRNNHKXMDDVLUQHWCSKKKJFBEHKLMJZDEPRZSMYFQMIBJKDYIZDUFVXCM" +
          "YHVTIHTSZCVVGDKWDQEYBQTPAOKPPGGNYWPRIQOUZITSPBAHZHTRNLPNCSHPFUWJJQDVMZGEXZIKMQXHOQRCI" +
          "EWQLUQVFLELOUFYMDJFVCJWJIVULVKAZBHRPSCNVXEPJHINOWPFMEUSGQVMXDBHPEDAOXWBBXGUOHVINJAVTV" +
          "XDVPVYRDOFENTCHZLMIOECLJRXMFJAOFHAZNZAPVQZEMMTJFDJIHURPBCCDXHWNTMSGYQQGLOGRPVGWWJFTSK" +
          "SUZAKKTIEXNEGVADHGIGSJQAFSRNMDVLIZVLIPJQJZRMQAGITGCLMRALDUMVRUIRZRIONCEQDAWEOXMCXGOTK" +
          "YPBICDCRJLDEJDWREIGWVVOKYOCNOQHGWNDELTIBCNSZLHZAPRWBRMHJQKCZSTNNJUQIIFFVPXPRXKUQVNDEQ" +
          "YOEITDYFZDQRBNCUEMQEYLNHHELQSWXWCDURSEQBUWKRYDXBGUQMENGNLGANERVIGDSMCJSXGUGJYZSRDLBUW" +
          "GMBBHWEBMMDIZLRACVKTTJTJYNCQHFEBIGTWXRXQMUKCHJQNKZRARDXHSOSLXYRXDCPKMUWUGMFGROFHQPAYT" +
          "ABBZEFUAVVIXYJGBJIXIPUBTAYWYIKRCNEMIVOWFBNLTBRRLNRXTQEHGHWKYRJYIKFTSKAHJQLVBSUUPGTBUV" +
          "EARNFXIVULOTNOCFDIMPFORADOFOBPKIFXRZZCANBXNTVCCGOLKDUSSPWIFVHMQJCPGHAMOHBEDAXIILTXEDY" +
          "BUNSMYYITUCIVWJFXJPZLZZVUZIOWUQQUZEEGODVQFMDKDPQPPSQTVYVEYSAIPTCINKVWKVZIZPSZDOCFDHHB" +
          "VWLNDZZLQPSNXKJBERLORWRKIQHOOXOKBODPALHOVMDIACIBSUHWPIAURJDMVKPNMFCTSVRKNFBTARMTDCDZK" +
          "GNHTUTMTJFICCCSABITMGWRMUCHLQMBXHUGZLAKQCEYZUYRDYLLCHPGVLJIRPTRHYSMUYKEVKOPKMDTDLWPPE" +
          "IWJLLAGDIOTKOUXOVEGTHDCCUZDYLRHBNFJVAXSKRIRCZQQOYXGEJECKZDOMWNVLHKYBDKRMZANLUHMEWOTEA" +
          "KCALXPXUBHDUQEXQFQSSJEQUBHVCHRHHJNRHLYJMQJCZMIANZMAKJPHOTMTSGRYWUJGQNYYSYCDOOYGVMGFCV" +
          "KMJNLKAXHCZIOSZDKBZOTQTPESFKICVKHSRTNYNDVPFJOVBWALBDPQIJRYKECTTVEUOXVGBFYYLBZDITKPQIO" +
          "SOJRXMPMVTDXFMIJOOPSTYKZFWRLJORWYKEXDNUTRGHTTQJDEONAZEIAJURXVRFZJHCIYOJCRQMUTLOMGWMYN" +
          "ZNIPNYMCUXCRIPJNTKXMZRWQVNTWWOZTPYUNLRXPBNUAUAXOQEMXJMVRUNOPZMGDFJUYRHXTLKZPIAEWWJYPS" +
          "CKKQTKYNXCISUAWCQPBZPLJJINVKFNQTPLZCWIFCFUDNTWBDHDKNEBMMDERFLZIZPUYIQCFQPEWZUFMHSKPUH" +
          "BKSNWCYHGKCTRYBRACSLHGVHTISIJBIDSEGXYQATMJVPDUSUVELXGSMCCOSADIKAHNXYARKGQRYEJNMRQARBB" +
          "TPOSOMIDKIUWTMSIKHLDMZNTPEHKFSZGQKMRMLZXADOSHNKOSGGARFBCAZVQUXILUCGZKCIRDLEJACGZEGXOV" +
          "VNIECICBAGHZTXDXMHSHSBTXCTBOQOQHTXLLLJEMWRHEIWBOPSUVXZDJOZRPZLVXVOEBXXTUXJANHZJXCFKGY" +
          "EDWRTQTZMVIGNXRRXIKFFTJRVQUTALBRSSHSXDBAXCTRXPXNESIKFKMZFRBVXBZUOBBWAWPOOFNVBLOJDUAQC" +
          "TMVLIVTXMKQSTRTUQXTJIARGNUIDDVLKBJACZOPSUFDBJFZSQBDYVOZPFTXDMSMRTZKYJUNYCFKZKHOOBEYHF" +
          "LTIEKXCRLNZYTOVZKBFMCSDAWEBXRLTAVOAWKSSGFXZHNCOUIPXFIVKNEACZJUHCHUYZJZIVAQVXDYDLZMLPG" +
          "FIQEDITULCELTSKSJQKWGJUSQGIYUNTXMZHJQDRZHTVDOTXFBVVJRJPFYDGCPQZTYIWQMULIPPXNACUTOKJYB" +
          "ULGOEXNBFUQAEBGJVDHJIHBOYJFLFMAGPBJADKHSNXNHJSGFPBXPHGQFTGEKOBPMGTKYJLZWJUYXLGAMFCFWR" +
          "EPCMWLHSVMAGUSXTNUGSCIYQAWVHHIJQNQXTBSYNEDRDJRVJQFMCIJIXVJKNSZBULKCATAIZBXKLUWCHCKEUA" +
          "KLDFBWADPMYPOXCDKTVCYEPCQGSEIBAKELDCWHHMSRHKWLOVZQDADNWIQYFNYOMJHCIUGRKYDFUTILBUCZGKJ" +
          "KQZMXDVGCZDKFXYMISBNMKSRUFARSUMDSRENQRETHWIJDYOSULKVDVAKDXSKGNSHGRSJDGNFXSOBMXTOEGIHQ" +
          "KWLEMSUJAKDGUOLYIYCVZXFEHWFUDLMCGZYDUAJWOEUQPWVHDFRZAGBFVGOTIMGXGMRVSPVIOASOWGADBTCWA" +
          "UYAEOVLKMJBBZRITWYKQJYEXOGQLZDCNJTFYRBGZUVYGGUYMJGIDQWNOQNZAIRSLLGRODNOGIPIZUZOELXTZZ" +
          "LLUHNPSXKLWOUFYNTTUFMBMGWFBIURNSAXMOPFTWDSMANZSNESOYQVLZCOZSGRSRYOBSWVJBPIQWFXTEIRBRJ" +
          "XXXBYWIYWPQXOVNSZHZLPXAKXSNJEWDKRHPMEBGKDPZKGSCBIMOSSIAIOTCYLBDTWBIOJTOJYDEDDPJBNQLGG" +
          "VWXIJGASJYNWPSMBAHWLIYSVWWATJMGLXTORJUOGUTZJCLSIKGUWTAJQLUODMRDSOXTYWENOPFAYJLJCJYWCK" +
          "ARVWGMMMZEREZZRZRIYRUVVICJCIWFOBSHBPMIIUHVZVWPMHPKZBQLWTAZETNVFVVEGMBNFKNOOYHVHNNWJND" +
          "OMGVPVYRCWVWNWXXQUAEZZVQTDYNYTSAJCLVGDZSQHNRDBPVZUVOUFILTIMAZXHAKWZAIDETWXQXKFOOFAOUW" +
          "SPSFFNOOMXWIOHLOUTMUWHNARDGPTHNQIDSGLXAHTWSUMTUHLIIWOHZPWTEHJBOEBUFDODRJCHVYZGLTEIYZX" +
          "DZVTHGOZRXHKFPYHIZOGQWBUGTJYGYNNKERORDYLRPRRUFDRIEYZFSNVGICYQURXDCCNBZUIARXWUELWQPCKE" +
          "RYMKEAZPMPSJFODLFEGCVEZXEHFTJJCFHUXZWTJIONJPAXARJXBUTJXNJDYAAONEMLMKFTZNDFCZXNNZPANZX" +
          "FSFDEADRLOBXYHOCWBNVEIYEEGXUFAJDUVIERTSSOCYXMKUBUOBNJLXQDXYAKGEVENKYOMKJIPXKJRVINATCV" +
          "YEZQFMQTGMKVGFGALSMCCHFIIWDMAWZGHOZXKOAQQFGQQFKWPGVYISCBOTFJVUEAMEYEPSPMXRCWCKFYUUXHH" +
          "DQSUFCZPZFTJAMKPKFYHHSQJGKIEGINKJLDRQXCRNRXNISLXAVNWRKOVBUNNYQRVBGKCISIIRULWMXEUWXRRJ" +
          "NMZAZJYEIKLUVGNXRKNRKTBJRCLAKXPOCMUEBUYDNLMFHEUHBADMIWYFCEXCFTLYJRXPLWYSHIOLPFKHBWJXI" +
          "ZTMBHFOBZBYSFESVTSBERKIJISNFKYNBLDYTFLSHGVKYJSOWOTVNCXV", 7520, ExpectedResult = 7864 )]
    public int CharacterReplacementTest( string s, int k ) => new LongestRepeatingCharacterReplacement().CharacterReplacement( s, k );
}
