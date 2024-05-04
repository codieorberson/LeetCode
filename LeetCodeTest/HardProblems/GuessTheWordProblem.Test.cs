using LeetCode.HardProblems;

namespace LeetCodeTest.HardProblems
{
    [TestClass]
    public class GuessTheWordProblemTest
    {
        GuessTheWordProblem guessTheWordProblem;

        [TestInitialize]
        public void Setup()
        {
            guessTheWordProblem = new GuessTheWordProblem();
        }

        [TestMethod]
        public void GuessTheWord()
        {
            string[] words = new string[] { "wichbx", "oahwep", "tpulot", "eqznzs", "vvmplb", "eywinm", "dqefpt", "kmjmxr", "ihkovg", "trbzyb", "xqulhc", "bcsbfw", "rwzslk", "abpjhw", "mpubps", "viyzbc", "kodlta", "ckfzjh", "phuepp", "rokoro", "nxcwmo", "awvqlr", "uooeon", "hhfuzz", "sajxgr", "oxgaix", "fnugyu", "lkxwru", "mhtrvb", "xxonmg", "tqxlbr", "euxtzg", "tjwvad", "uslult", "rtjosi", "hsygda", "vyuica", "mbnagm", "uinqur", "pikenp", "szgupv", "qpxmsw", "vunxdn", "jahhfn", "kmbeok", "biywow", "yvgwho", "hwzodo", "loffxk", "xavzqd", "vwzpfe", "uairjw", "itufkt", "kaklud", "jjinfa", "kqbttl", "zocgux", "ucwjig", "meesxb", "uysfyc", "kdfvtw", "vizxrv", "rpbdjh", "wynohw", "lhqxvx", "kaadty", "dxxwut", "vjtskm", "yrdswc", "byzjxm", "jeomdc", "saevda", "himevi", "ydltnu", "wrrpoc", "khuopg", "ooxarg", "vcvfry", "thaawc", "bssybb", "ccoyyo", "ajcwbj", "arwfnl", "nafmtm", "xoaumd", "vbejda", "kaefne", "swcrkh", "reeyhj", "vmcwaf", "chxitv", "qkwjna", "vklpkp", "xfnayl", "ktgmfn", "xrmzzm", "fgtuki", "zcffuv", "srxuus", "pydgmq" };
            string actualWord = "ccoyyo";
            int attempts = 10;

            var actual = guessTheWordProblem.GuessTheWord(words, actualWord, attempts);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void GuessTheWord2()
        {
            string[] words = new string[] { "pzrooh", "aaakrw", "vgvkxb", "ilaumf", "snzsrz", "qymapx", "hhjgwz", "mymxyu", "jglmrs", "yycsvl", "fuyzco", "ivfyfx", "hzlhqt", "ansstc", "ujkfnr", "jrekmp", "himbkv", "tjztqw", "jmcapu", "gwwwmd", "ffpond", "ytzssw", "afyjnp", "ttrfzi", "xkwmsz", "oavtsf", "krwjwb", "bkgjcs", "vsigmc", "qhpxxt", "apzrtt", "posjnv", "zlatkz", "zynlqc", "czajmi", "smmbhm", "rvlxav", "wkytta", "dzkfer", "urajfh", "lsroct", "gihvuu", "qtnlhu", "ucjgio", "xyycvd", "fsssoo", "kdtmux", "bxnppe", "usucra", "hvsmau", "gstvvg", "ypueay", "qdlvod", "djfbgs", "mcufib", "prohkc", "dsqgms", "eoasya", "kzplbv", "rcuevr", "iwapqf", "ucqdac", "anqomr", "msztnf", "tppefv", "mplbgz", "xnskvo", "euhxrh", "xrqxzw", "wraxvn", "zjhlou", "xwdvvl", "dkbiys", "zbtnuv", "gxrhjh", "ctrczk", "iwylwn", "wefuhr", "enlcrg", "eimtep", "xzvntq", "zvygyf", "tbzmzk", "xjptby", "uxyacb", "mbalze", "bjosah", "ckojzr", "ihboso", "ogxylw", "cfnatk", "zijwnl", "eczmmc", "uazfyo", "apywnl", "jiraqa", "yjksyd", "mrpczo", "qqmhnb", "xxvsbx" };
            string actualWord = "anqomr";
            int attempts = 10;

            var actual = guessTheWordProblem.GuessTheWord(words, actualWord, attempts);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void GuessTheWord3()
        {
            string[] words = new string[] { "pzrooh", "aaakrw", "vgvkxb", "ilaumf", "snzsrz", "qymapx", "hhjgwz", "mymxyu", "jglmrs", "yycsvl", "fuyzco", "ivfyfx", "hzlhqt", "ansstc", "ujkfnr", "jrekmp", "himbkv", "tjztqw", "jmcapu", "gwwwmd", "ffpond", "ytzssw", "afyjnp", "ttrfzi", "xkwmsz", "oavtsf", "krwjwb", "bkgjcs", "vsigmc", "qhpxxt", "apzrtt", "posjnv", "zlatkz", "zynlqc", "czajmi", "smmbhm", "rvlxav", "wkytta", "dzkfer", "urajfh", "lsroct", "gihvuu", "qtnlhu", "ucjgio", "xyycvd", "fsssoo", "kdtmux", "bxnppe", "usucra", "hvsmau", "gstvvg", "ypueay", "qdlvod", "djfbgs", "mcufib", "prohkc", "dsqgms", "eoasya", "kzplbv", "rcuevr", "iwapqf", "ucqdac", "anqomr", "msztnf", "tppefv", "mplbgz", "xnskvo", "euhxrh", "xrqxzw", "wraxvn", "zjhlou", "xwdvvl", "dkbiys", "zbtnuv", "gxrhjh", "ctrczk", "iwylwn", "wefuhr", "enlcrg", "eimtep", "xzvntq", "zvygyf", "tbzmzk", "xjptby", "uxyacb", "mbalze", "bjosah", "ckojzr", "ihboso", "ogxylw", "cfnatk", "zijwnl", "eczmmc", "uazfyo", "apywnl", "jiraqa", "yjksyd", "mrpczo", "qqmhnb", "xxvsbx" };
            string actualWord = "anqomr";
            int attempts = 11;

            var actual = guessTheWordProblem.GuessTheWord(words, actualWord, attempts);
            Assert.IsTrue(actual);
        }
    }
}
