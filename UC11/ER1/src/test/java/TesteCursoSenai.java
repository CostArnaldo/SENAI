import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteCursoSenai {
	
	private WebDriver driver;
	
	@Before
	
	public void ConfigurarTeste() {
	System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\ChromeDriver\\chromedriver.exe");
	driver = new ChromeDriver();
	driver.manage().window().maximize();
	driver.get("http://www.google.com");
	driver.findElement(By.className("gLFyf"));
	driver.findElement(By.className("gLFyf")).sendKeys("senai informatica");
	driver.findElement(By.className("gLFyf")).sendKeys(Keys.ENTER);
	driver.findElement(By.xpath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div[1]/a/h3")).click();
	
	}
	@Test
		public void TesteN() {
	
	driver.findElement(By.id("Busca1_txtFiltro")).sendKeys("excel");
	driver.findElement(By.id("Busca1-btnBusca")).click();
	}
	
	
}
