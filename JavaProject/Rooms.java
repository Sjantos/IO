
public class Rooms {
	private Room[] all_rooms;
	private Room[] fitting_rooms;
	
	public Room[] Find_free_room(Date start_date, Date end_date, int capacity)
	{
		return fitting_rooms;
	}

	public Room[] getAll_rooms() {
		return all_rooms;
	}
	
	public void Check_in_client(String reservation_id) {
		
	}
	
	public void Check_out_client(String reservation_id) {
		
	}

	public void setAll_rooms(Room[] all_rooms) {
		this.all_rooms = all_rooms;
	}

	public Room[] getFitting_rooms() {
		return fitting_rooms;
	}

	public void setFitting_rooms(Room[] fitting_rooms) {
		this.fitting_rooms = fitting_rooms;
	}

}
