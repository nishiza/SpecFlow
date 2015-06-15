﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("External Step Definitions")]
    public partial class ExternalStepDefinitionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ExternalSteps.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "External Step Definitions", "In order to modularize my solution\r\nAs a bdd enthusiast\r\nI want to use step defin" +
                    "itions from other assemblies", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can defined in an external .NET (e.g. c# or VB.NET) project")]
        public virtual void StepsCanDefinedInAnExternal_NETE_G_COrVB_NETProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can defined in an external .NET (e.g. c# or VB.NET) project", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("there is an external class library project \'ExternalSteps\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("the following step definition in the external library", "[When(@\"I do something\")]\r\npublic void WhenIDoSomething()\r\n{\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("there is a SpecFlow project with a reference to the external library", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the specflow configuration is", "<specFlow>\r\n<stepAssemblies>\r\n<stepAssembly assembly=\"ExternalSteps\" />\r\n</stepAs" +
                    "semblies>\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("all tests should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can defined in an external F# project")]
        [NUnit.Framework.CategoryAttribute("fsharp")]
        public virtual void StepsCanDefinedInAnExternalFProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can defined in an external F# project", new string[] {
                        "fsharp"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("there is an external F# class library project \'ExternalSteps_FSharp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.And("the following binding class", "[<TechTalk.SpecFlow.Binding>]\r\nmodule Bindings\r\n\r\nlet [<TechTalk.SpecFlow.When(@\"" +
                    "I do something\")>] WhenIDoSomething() = ()", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("there is a SpecFlow project with a reference to the external library", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the specflow configuration is", "<specFlow>\r\n<stepAssemblies>\r\n<stepAssembly assembly=\"ExternalSteps_FSharp\" />\r\n<" +
                    "/stepAssemblies>\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("all tests should pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
