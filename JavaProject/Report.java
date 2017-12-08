import java.util.Date;
public class Report {
	private Date date;
	private double cash;
	private boolean card;
	
	public Date getDate() {
		return date;
	}
	
	public void setDate(Date date) {
		this.date = date;
	}
	
	public double getCash() {
		return cash;
	}
	
	public void setCash(double cash) {
		this.cash = cash;
	}
	
	public boolean isCard() {
		return card;
	}
	
	public void setCard(boolean card) {
		this.card = card;
	}

}
