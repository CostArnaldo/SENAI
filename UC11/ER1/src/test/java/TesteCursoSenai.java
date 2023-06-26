import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteCursoSenai {
	
	private WebDriver driver;
	
	@Before
	
	public void ConfigurarTeste() {
	System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\ChromeDriver\\chromedriver.exe");
	driver = new ChromeDriver();
	driver.manage().window().maximize()
;	driver.get("http://www.google.com");
	}
	@Test
		public void TesteN() {}
}
