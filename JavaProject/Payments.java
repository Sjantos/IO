
public class Payments {
	private Payment[] all_payments;
	private double actual_card_payments;
	private double actual_cash_payments;
	
	public void PayOut_salary(String employee_ID){
		
	}
	
	public void Take_payment(double value, boolean card){
	}
	
	public void Give_bonus(String employee_id, double bonus){
		
	}
	
	public void Sum_actual_payment_for_daily_report(){
		
	}
	
	public Payment[] getAll_payments() {
		return all_payments;
	}
	
	public void setAll_payments(Payment[] all_payments) {
		this.all_payments = all_payments;
	}
	
	public double getActual_card_payments() {
		return actual_card_payments;
	}
	
	public void setActual_card_payments(double actual_card_payments) {
		this.actual_card_payments = actual_card_payments;
	}
	
	public double getActual_cash_payments() {
		return actual_cash_payments;
	}
	
	public void setActual_cash_payments(double actual_cash_payments) {
		this.actual_cash_payments = actual_cash_payments;
	}

}
