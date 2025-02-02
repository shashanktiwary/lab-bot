﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AwgTestFramework.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TC_76VerifyMTONeCOMPileCHANnelSyntaxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "test_0076.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")))
            {
                AwgTestFramework.Tests.TC_76VerifyMTONeCOMPileCHANnelSyntaxFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void VerifyMTONeCHANnelNAMESyntax(string command, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify MTONe:CHANnel:NAME Syntax", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
testRunner.Given("AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("the family is 70k for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("a reset for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.When("I load the MultiTone module for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I wait for operation complete for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("I send the \"{0}\" command for AWG 1", command), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.Then("there should be no error on AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMPile:CHANnel NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMPile:CHANnel NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONeCOMPileCHANnelNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTONe:COMPile:CHANnel NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMPile:CHAN NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMPile:CHAN NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONeCOMPileCHANNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTONe:COMPile:CHAN NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMP:CHANnel NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMP:CHANnel NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONeCOMPCHANnelNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTONe:COMP:CHANnel NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMP:CHAN NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMP:CHAN NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONeCOMPCHANNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTONe:COMP:CHAN NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMPile:CHANnel NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMPile:CHANnel NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONCOMPileCHANnelNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTON:COMPile:CHANnel NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMPile:CHAN NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMPile:CHAN NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONCOMPileCHANNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTON:COMPile:CHAN NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMP:CHANnel NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMP:CHANnel NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONCOMPCHANnelNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTON:COMP:CHANnel NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMP:CHAN NONE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMP:CHAN NONE")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONCOMPCHANNONE()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTON:COMP:CHAN NONE", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHANnel:NAME Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-76  ]  Verify MTONe:COMPile:CHANnel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMP:CHAN 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMP:CHAN 1")]
        public virtual void VerifyMTONeCHANnelNAMESyntax_MTONCOMPCHAN1()
        {
            this.VerifyMTONeCHANnelNAMESyntax("MTON:COMP:CHAN 1", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
