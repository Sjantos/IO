import java.util.Date;
import java.util.List;
public class Receptionist extends Employee implements I_Receptionist 
{
	private Client client;
	private List<Room> rooms;
	public void Make_reservation(String client_id, Date start_date, Date end_date, int room_number){
		if(!Clients.getClients().contains(Person.getId()==client_id))
		{
			Register_client(client.getLast_name(), client.getFirst_name(), client_id, client.getEmail());
		}
		else
		{
			Reservations.Make_reservation(client_id, start_date, end_date, room_number);
		}
	}
	public void Take_payment(String client_id, double value, boolean card){
		
	}
	public void Register_client(String last_name, String first_name, String client_id, String email){
		Clients.Register_client(last_name, first_name, client_id, email);
		
	}
	public List<Room> Find_free_room(Date start_date, Date end_date, int capacity){
		rooms=Reservations.Find_free_room(start_date, end_date, capacity);
		
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
