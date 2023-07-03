using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.HardProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            string[] words = new string[] { "pzrooh", "aaakrw", "vgvkxb", "ilaumf", "snzsrz", "qymapx", "hhjgwz", "mymxyu", "jglmrs", "yycsvl", "fuyzco", "ivfyfx", "hzlhqt", "ansstc", "ujkfnr", "jrekmp", "himbkv", "tjztqw", "jmcapu", "gwwwmd", "ffpond", "ytzssw", "afyjnp", "ttrfzi", "xkwmsz", "oavtsf", "krwjwb", "bkgjcs", "vsigmc", "qhpxxt", "apzrtt", "posjnv", "zlatkz", "zynlqc", "czajmi", "smmbhm", "rvlxav", "wkytta", "dzkfer", "urajfh", "lsroct", "gihvuu", "qtnlhu", "ucjgio", "xyycvd", "fsssoo", "kdtmux", "bxnppe", "usucra", "hvsmau", "gstvvg", "ypueay", "qdlvod", "djfbgs", "mcufib", "prohkc", "dsqgms", "eoasya", "kzplbv", "rcuevr", "iwapqf", "ucqdac", "anqomr", "msztnf", "tppefv", "mplbgz", "xnskvo", "euhxrh", "xrqxzw", "wraxvn", "zjhlou", "xwdvvl", "dkbiys", "zbtnuv", "gxrhjh", "ctrczk", "iwylwn", "wefuhr", "enlcrg", "eimtep", "xzvntq", "zvygyf", "tbzmzk", "xjptby", "uxyacb", "mbalze", "bjosah", "ckojzr", "ihboso", "ogxylw", "cfnatk", "zijwnl", "eczmmc", "uazfyo", "apywnl", "jiraqa", "yjksyd", "mrpczo", "qqmhnb", "xxvsbx" };
            string actualWord = "anqomr";
            int attempts = 11;

            var actual = guessTheWordProblem.GuessTheWord(words, actualWord, attempts);
            Assert.IsTrue(actual);
        }
    }
}
