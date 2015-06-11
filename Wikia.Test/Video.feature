Feature: Video
	In order keep the content engaging 
	As user 
	I want to be able to add video to Wikia

@Browser:Chrome
Scenario: Add video to wikia page
	Given I am logged into the wikia 
	When I Click on the contribute button
	And I Click on Add a video
	And I type the URL "https://www.youtube.com/watch?v=sFukyIIM1XI" of the video in the Video URL box
	And I click on Add 
	Then I should be taken to the video page
	And there should be a message on the top of the page saying "Video page File:Minions_Banana_Song_Full_Song_was_added_successfully_added"
	And the video with title "Minions Banana Song Full Song" should be added to the videos page 
	And the video title should be the same as the file name 

	@Broweser:Chrome
	Scenario: Add second video to wikia page
	Given I am logged into the wikia 
	When I Click on the contribute button
	And I Click on Add a video
	And I type the URL "https://youtu.be/etzMjoH0rJw" of the video in the Video URL box
	And I click on Add 
	Then I should be taken to the video page
	And there should be a message on the top of the page saying file was "successfully added"
	And the video with title "The LEGO Movie 'Everything is Awesome' Music Video" should be added to the videos page 
	And if I click on the flash success link then I will go to the video page with "The LEGO Movie 'Everything is Awesome' Music Video" video