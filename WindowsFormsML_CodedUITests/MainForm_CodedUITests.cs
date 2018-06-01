using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WindowsFormsML_CodedUITests
{
    /// <summary>
    /// Summary description for MainForm_CodedUITests
    /// </summary>
    [CodedUITest]
    public class MainForm_CodedUITests
    {
        [TestMethod]
        public void CodedUITest_tbBirthYear_IsNotReadOnlyAndHasEmptyStringAndIsNotNull()
        {
            UIMap.AssertMethod_tbBirthYear_IsNotReadOnly();
            UIMap.AssertMethod_tbBirthYear_HasEmptyString();
            UIMap.AssertMethod_tbBirthYear_IsNotNull();
        }

        [TestMethod]
        public void CodedUITest_tbBirthYear_HasCorrectYearInput()
        {
            UIMap.RecordedMethod_tbBirthYear_InputCorrectYear();
            UIMap.AssertMethod_tbBirthYear_HasCorrectYearInput();
        }

        [TestMethod]
        public void CodedUITest_tbBirthYear_HasIncorrectYearInput()
        {
            UIMap.RecordedMethod_tbBirthYear_InputIncorrectYear();
            UIMap.AssertMethod_tbBirthYear_HasIncorrectYearInput();
        }

        [TestMethod]
        public void CodedUITest_cbSex_HasCorrectSelectedSex()
        {
            UIMap.AssertMethod_cbSex_HasCorrectSelectedSex();
        }

        [TestMethod]
        public void CodedUITest_cbSex_HasIncorrectSelectedSex()
        {
            UIMap.RecordedMethod_cbSex_SelectIncorrectSex();
            UIMap.AssertMethod_cbSex_HasIncorrectSelectedSex();
        }

        [TestMethod]
        public void CodedUITest_cbClubMember_HasCorrectSelectedClubMemberStatus()
        {
            UIMap.AssertMethod_cbClubMember_HasCorrectSelectedClubMemberStatus();
        }

        [TestMethod]
        public void CodedUITest_cbClubMember_HasIncorrectSelectedClubMemberStatus()
        {
            UIMap.RecordedMethod_cbClubMember_SelectIncorrectClubMemberStatus();
            UIMap.AssertMethod_cbClubMember_HasIncorrectSelectedClubMemberStatus();
        }

        [TestMethod]
        public void CodedUITest_cbMovie_HasCorrectSelectedMovie()
        {
            UIMap.RecordedMethod_cbMovie_SelectCorrectMovie();
            UIMap.AssertMethod_cbMovie_HasCorrectSelectedMovie();
        }

        [TestMethod]
        public void CodedUITest_cbMovie_HasIncorrectSelectedMovie()
        {
            UIMap.RecordedMethod_cbMovie_SelectIncorrectMovie();
            UIMap.AssertMethod_cbMovie_HasIncorrectSelectedMovie();
        }

        [TestMethod]
        public void CodedUITest_cbMovie_ComboBoxIsEnabled()
        {
            UIMap.AssertMethod_cbMovie_ComboBoxIsEnabled();
        }

        [TestMethod]
        public void CodedUITest_cbMovie_ComboBoxIsDisenabled()
        {
            UIMap.RecordedMethod_cbMovie_DisenableComboBox();
            UIMap.AssertMethod_cbMovie_ComboBoxIsDisenabled();
        }

        [TestMethod]
        public void CodedUITest_cbGenre_HasCorrectSelectedGenre()
        {
            UIMap.RecordedMethod_cbGenre_SelectCorrectGenre();
            UIMap.AssertMethod_cbGenre_HasCorrectSelectedGenre();
        }

        [TestMethod]
        public void CodedUITest_cbGenre_HasIncorrectSelectedGenre()
        {
            UIMap.RecordedMethod_cbGenre_SelectIncorrectGenre();
            UIMap.AssertMethod_cbGenre_HasIncorrectSelectedGenre();
        }

        [TestMethod]
        public void CodedUITest_cbIncludeMovies_CheckBoxIsUnchecked()
        {
            UIMap.AssertMethod_cbIncludeMovies_CheckBoxIsUnchecked();
        }

        [TestMethod]
        public void CodedUITest_cbIncludeMovies_CheckBoxIsChecked()
        {
            UIMap.RecordedMethod_cbIncludeMovies_ActivateCheckBox();
            UIMap.AssertMethod_cbIncludeMovies_CheckBoxIsChecked();
        }

        [TestMethod]
        public void CodedUITest_tabControl1_lbGenreAndlbMovieAreReset()
        {
            UIMap.AssertMethod_tabControl1_lbGenreIsReset();
            UIMap.RecordedMethod_tabControl1_SelectlbMovieOnTabControl();
            UIMap.AssertMethod_tabControl1_lbMovieIsReset();
        }

        [TestMethod]
        public void CodedUITest_btnCalculate_PopulatelbMovieAndlbGenre()
        {
            UIMap.RecordedMethod_btnCalculate_PopulatelbMovieAndlbGenre();
            // Has a 25 seconds delay inserted here due to a longer response time from the Azure ML web server.
        }

        [TestMethod]
        public void CodedUITest_btnCalculate_lbGenreAndlbMovieArePopulated()
        {
            UIMap.AssertMethod_btnCalculate_lbMovieIsPopulated();
            UIMap.RecordedMethod_btnCalculate_SelectlbGenreOnTabControl();
            UIMap.AssertMethod_btnCalculate_lbGenreIsPopulated();
        }

        [TestMethod]
        public void CodedUITest_btnReset_CleartbBirthYearAndlbMovieAndlbGenre()
        {
            UIMap.AssertMethod_btnReset_lbGenreIsNotReset();
            UIMap.RecordedMethod_btnReset_SelectlbMovieOnTabControl();
            UIMap.AssertMethod_btnReset_lbMovieIsNotReset();
            UIMap.RecordedMethod_btnReset_CleartbBirthYearAndlbMovieAndlbGenre();
            UIMap.AssertMethod_btnReset_tbBirthYearIsReset();
            UIMap.AssertMethod_btnReset_lbMovieIsReset();
            UIMap.RecordedMethod_btnReset_SelectlbGenreOnTabControl();
            UIMap.AssertMethod_btnReset_lbGenreIsReset();
        }

        [TestMethod]
        public void CodedUITest_btnUpdate_ClearAndRepopulateAllComboBoxes()
        {
            UIMap.RecordedMethod_btnUpdate_ClearAndRepopulateAllComboBoxes();
            //Has a 5 seconds delay inserted here due to a slow computer.
            UIMap.AssertMethod_btnUpdate_cbSexIsPopulated();
            UIMap.AssertMethod_btnUpdate_cbClubMemberIsPopulated();
            UIMap.AssertMethod_btnUpdate_cbMovieIsPopulated();
            UIMap.AssertMethod_btnUpdate_cbGenreIsPopulated();
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
