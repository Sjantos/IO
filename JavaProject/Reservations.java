import java.util.Date;
import java.util.List;
public class Reservations {
	private static Reservation[] all_reservations;
	private static List<Room> free_rooms;
	public static Reservation[] getAll_reservations() {
		return all_reservations;
	}

	public static void setAll_reservation(Reservation reservation, int index) {
		Reservations.all_reservations[index] = reservation;
	}

	public Reservation getOne_reservations(int index) {
		return all_reservations[index];
	}
	
	public static String Make_reservation(String client_id, Date start_date, Date end_date, int room_number)
	{
		int capacity = 0;
		if (Find_free_room(start_date,end_date,capacity).isEmpty())
		{
			return "nie ma wolnego pokoju";
		}
		else
		{
		Reservation res = new Reservation(client_id, start_date, end_date, room_number);
		
		setAll_reservation(res, getAll_reservations().length);
		return "rezerwacja dokonana";
		}
	}
	public void Cancel_reservation(String reservation_id)
	{
		
	}

	public static List<Room> Find_free_room(Date start_date, Date end_date, int capacity) {
		int number;
		for(int i=0; i<getAll_reservations().length;i++)
		{
			if(all_reservations[i].getStart_date().after(start_date) && all_reservations[i].getStart_date().equals(start_date))
			{
				number=all_reservations[i].getRoom_number();
				free_rooms.remove(number);

			}
		}
		
		return free_rooms;
	}

	public static List<Room> getFree_rooms() {
		return free_rooms;
	}

	public static void setFree_rooms(List<Room> free_rooms) {
		Reservations.free_rooms = free_rooms;
	}

	public static Room getFree_room(int index) {
		return free_rooms.get(index);
	}

}
