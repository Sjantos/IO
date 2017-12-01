
public class Receptionist extends Employee implements I_Receptionist 
{
	private Client client;
	private Room[] rooms;
	public void Make_reservation(String client_id, Date start_date, Date end_date, int room_number){
		
	}
	public void Take_payment(String client_id, double value, boolean card){
		
	}
	public void Register_client(String last_name, String first_name, String client_id, String email){
		
	}
	public Room[] Find_free_room(Date start_date, Date end_date, int capacity){
		
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

}
