using LSportsHomeTask.covidIsraelisTest.Infra;
using LSportsHomeTask.covidIsraelisTest.pages;
using LSportsHomeTask.covidIsraelisTest.tests;

namespace LSportsHomeTask
{
    public class Tests : BaseTest
    {


        [Test]
        [Category("covidPopUpPageTestInBooking")]
        public void CovidRestrictionForIsraelisTest()
        {
            String pageUrl = "https://www.booking.com/";
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



        }
    }
}