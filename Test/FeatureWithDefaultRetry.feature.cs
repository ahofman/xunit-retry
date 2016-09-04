﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "featuretag")]
    [Xunit.TraitAttribute("Category", "retry")]
    public partial class AFeatureWithDefaultRetriesFeature : Xunit.IClassFixture<AFeatureWithDefaultRetriesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureWithDefaultRetry.feature"
#line hidden
        
        public AFeatureWithDefaultRetriesFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "A feature with default retries", null, ProgrammingLanguage.CSharp, new string[] {
                        "featuretag",
                        "retry"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(AFeatureWithDefaultRetriesFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "A feature with default retries")]
        [Xunit.TraitAttribute("Description", "Try do something a few times with another tag")]
        [Xunit.RetryFactAttribute(3)]
        [Xunit.TraitAttribute("Category", "scenariotag")]
        public virtual void TryDoSomethingAFewTimesWithAnotherTag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try do something a few times with another tag", new string[] {
                        "scenariotag"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("I try something 3 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "A feature with default retries")]
        [Xunit.TraitAttribute("Description", "Try do something a few times with another retry inside scenario")]
        [Xunit.TraitAttribute("Category", "scenariotag")]
        [Xunit.TraitAttribute("Category", "retry(12)")]
        [Xunit.RetryFactAttribute(12)]
        public virtual void TryDoSomethingAFewTimesWithAnotherRetryInsideScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try do something a few times with another retry inside scenario", new string[] {
                        "scenariotag",
                        "retry(12)"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.When("I try something", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "A feature with default retries")]
        [Xunit.TraitAttribute("Description", "Try do something a few times with retry from feature")]
        [Xunit.RetryFactAttribute(3)]
        public virtual void TryDoSomethingAFewTimesWithRetryFromFeature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try do something a few times with retry from feature", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.When("I try something 3 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AFeatureWithDefaultRetriesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AFeatureWithDefaultRetriesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
