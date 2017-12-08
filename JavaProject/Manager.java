import java.util.Date;
import java.util.List;
public class Manager extends Employee implements I_Receptionist, I_Manager, I_Repairman, I_Cleaner {
	
	private Client client;
	private List<Room> rooms;
	public void Make_reservation(String client_id, Date start_date, Date end_date, int room_number){
		
	}
	public void Take_payment(String client_id, double value, boolean card){
		
	}
	public void Register_client(String last_name, String first_name, String client_id, String email){
		
	}
	public List<Room> Find_free_room(Date start_date, Date end_date, int capacity){
		
		return rooms;
	}
	public void Check_in_client(String reservation_id){
		
	}
	public void Cancel_reservation(String reservation_id){
		
	}
	public void Check_out_client(String reservation_id){
		
	}
	public Client Find_client(String client_id){

		return client;
	}
	public void Call_menager(String place){
		
	}
	public void report_need_for_cleaning(int room_number){
		
	}
	public void report_need_for_repair(int room_number){
		
	}
	public void report_need_for_security_intervention(int room_number){
		
	}
	public void Report_execution_of_cleaning(int room_number){
		
	}
	public void Report_execution_of_repair(int room_number){
		
	}
	public void View_reports(){
		
	}
	public void Print_and_archive_report(Date date){
		
	}
	public void Add_daily_report(){
		
	}
	public void PayOut_salary(String employee_ID){
		
	}
	public void Give_bonus(String employee_id, double bonus){
		
	}
	public void Calculate_salary(String employee_id){
		
	}
	public void Fire_employee(String employee_id){
		
	}
	public void Check_hotel_statistics(){
		
	}
	public void Call_employee(String employee_id){
		
	}
	public void Warn_employee(String employee_id){
		
	}


	
}
