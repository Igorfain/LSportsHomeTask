using FluentAssertions;
using LSportsHomeTask.covidIsraelisTest.Infra;
using LSportsHomeTask.covidIsraelisTest.pages;

namespace LSportsHomeTask.covidIsraelisTest.tests
{
    public class Tests : BaseTest
    {


        [Test]
        [Category("Booking Covid PopUp PageTest")]
        public void CovidRestrictionForIsraelisTest()
        {
            string popupMessage = "Most travelers from Israel can enter France, but there are restrictions.";
            string pageUrl = "https://www.booking.com/";

            ConsoleReporter.Log("Step 1 - Navigate to Booking Home Page + Step 2 -Click On Attractions link");
            HomePage homePage = new HomePage(driver, wait)
                .OpenHomePage(driver, wait, pageUrl)
                .ClickAttractionsLink(driver, wait);

            ConsoleReporter.Log("Step 3 - Click on Read More link");
            AttractionsPage attractionsPage = new AttractionsPage(driver, wait);
            attractionsPage.ClickReadMoreLink(driver, wait);

            ConsoleReporter.Log("Step 4 - Fill the fields");
            CovidTravelsPage covidTravelsPage = new CovidTravelsPage(driver, wait);
            covidTravelsPage.FillPersonalData(driver, wait);

            ConsoleReporter.Log("Step 5 - Verify Covid-info popup displayed");
            covidTravelsPage.VerifyPopupInfoIsDisplayed(driver, wait, popupMessage).Should().BeTrue().Print("Covid Popup displayed");

            ConsoleReporter.Log("Step 6 - Get the text of the first paragraph and print it to the Log");
            covidTravelsPage.GetTextFromPopup(driver);



        }
    }
}