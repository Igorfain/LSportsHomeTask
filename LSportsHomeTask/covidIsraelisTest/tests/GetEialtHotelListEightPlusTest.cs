using LSportsHomeTask.covidIsraelisTest.Infra;
using LSportsHomeTask.covidIsraelisTest.pages;

namespace LSportsHomeTask.covidIsraelisTest.tests
{
    internal class GetEialtHotelListEightPlusTest : BaseTest
    {

        [Test]
        public void GetEilatHotelsScoreEightPlus()
        {
            string pageUrl = "https://www.booking.com/";
            ConsoleReporter.Log("Step 1 - Navigate to Booking Home Page");
            HomePage homePage = new HomePage(driver, wait)
                .OpenHomePage(driver, wait, pageUrl);
            ConsoleReporter.Log("Step 2 - Click on “Explore deals”");
            homePage.ClickExploreDealsLink(driver, wait);
            ConsoleReporter.Log("Step 2 - Search Eilat hotels");
            DealsPage dealsPage = new DealsPage(driver,wait);
            dealsPage.SearchEilatHotels(driver, wait);

        }
    }
}
