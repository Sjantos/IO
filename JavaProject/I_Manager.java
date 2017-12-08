import java.util.Date;
public interface I_Manager {
	public void View_reports();
	public void Print_and_archive_report(Date date);
	public void Add_daily_report();
	public void PayOut_salary(String employee_ID);
	public void Give_bonus(String employee_id, double bonus);
	public void Calculate_salary(String employee_id);
	public void Fire_employee(String employee_id);
	public void Check_hotel_statistics();
	public void Call_employee(String employee_id);
	public void Warn_employee(String employee_id);
}
