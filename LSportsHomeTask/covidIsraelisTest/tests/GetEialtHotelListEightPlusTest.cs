using FluentAssertions;
using LSportsHomeTask.covidIsraelisTest.Infra;
using LSportsHomeTask.covidIsraelisTest.pages;

namespace LSportsHomeTask.covidIsraelisTest.tests
{
    internal class GetEialtHotelListEightPlusTest : BaseTest
    {

        [Test]
        public void GetEilatHotelsScoreEightPlus()
        {
            double score = 8.0;
            string pageUrl = "https://www.booking.com/";
            ConsoleReporter.Log("Step 1 - Navigate to Booking Home Page");
            HomePage homePage = new HomePage(driver, wait)
                .OpenHomePage(driver, wait, pageUrl);

            ConsoleReporter.Log("Step 2 - Click on “Explore deals”");
            homePage.ClickExploreDealsLink(driver, wait);

            ConsoleReporter.Log("Step 3 - Search Eilat hotels");
            DealsPage dealsPage = new DealsPage(driver, wait);
            dealsPage.SearchEilatHotels(driver, wait);

            ConsoleReporter.Log("Step 4 - Select Review Score-Very Good +8 checkbox");
            EilatSearchResultPage eilatSearchResultPage = new EilatSearchResultPage(driver, wait);
            eilatSearchResultPage.SelectVeryGoodCheckBox(driver, wait);
            eilatSearchResultPage.VerifyAllResultsAreEightAndUp(driver, wait,score).Should().BeTrue().Print($"All resultse are {score} and greater");    
        }
    }
}
