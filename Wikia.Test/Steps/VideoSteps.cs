using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Wikia.Test.Pages;
using NUnit.Framework;

namespace Wikia.Test.Steps
{
    [Binding]
    public class VideoSteps:BaseSteps
    {
        [Given(@"I am logged into the wikia")]
        public void GivenIAmLoggedIntoTheWikia()
        {
            CurrentPage.As<IndexPage>().EnterUserName("saswatpatnaik");
            CurrentPage.As<IndexPage>().EnterPassword("P@ssword-1");
            CurrentPage.As<IndexPage>().ClickLogin();
        }

        [When(@"I Click on the contribute button")]
        public void WhenIClickOnTheContributeButton()
        {
            CurrentPage.As<IndexPage>().ClickOnContributeButton();

        }

        [When(@"I Click on Add a video")]
        public void WhenIClickOnAddAVideo()
        {
            CurrentPage.As<IndexPage>().SelectAddVideoFromContributeDropdown();
        }

        [When(@"I type the URL ""(.*)"" of the video in the Video URL box")]
        public void WhenITypeTheURLOfTheVideoInTheVideoURLBox(string p0)
        {
            CurrentPage.As<AddVideosPage>().TypeVideoURL(p0);
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            CurrentPage.As<AddVideosPage>().ClickOnAddButton();
        }


        [Then(@"I should be taken to the video page")]
        public void ThenIShouldBeTakenToAddVideoPage()
        {
            CurrentPage.Is<AddVideosPage>();
        }

        [Then(@"there should be a message on the top of the page saying file was ""(.*)""")]
        public void ThenThereShouldBeAMessageOnTheTopOfThePageSayingFileWas(string p0)
        {
            CurrentPage.As<VideosPage>().IsTextOnPage(p0);
        }

        [Then(@"the video with title ""(.*)"" should be added to the videos page")]
        public void ThenTheVideoWithTitleShouldBeAddedToTheVideosPage(string p0)
        {
            CurrentPage.As<VideosPage>().IsTextOnPage(p0);
        }

        [Then(@"if I click on the flash success link then I will go to the video page with ""(.*)"" video")]
        public void ThenIfIClickOnTheFlashSuccessLinkThenIWillGoToTheVideoPageWithVideo(string p0)
        {
            CurrentPage.As<VideosPage>().ClickOnSuccessMessageAndCheckVideo(p0);
            
        }


        //[Then(@"the video with title ""(.*)"" should be added to the videos page")]
        //public void ThenTheVideoWithTitleShouldBeAddedToTheVideosPage(string p0)
        //{
        //    CurrentPage.As<VideosPage>().IsTextPresent(p0);
        //}

        //[Then(@"the video title should be the same as the file name")]
        //public void ThenTheVideoTitleShouldBeTheSameAsTheFileName()
        //{
        //    CurrentPage.As<VideosPage>().IsTitleNameSameAsFileName();
        //}

    }
}
