import java.util.Date;
import java.util.List;
public class Rooms {
	private static Room[] all_rooms;
	private List<Room> fitting_rooms;
	
	public List<Room> Find_free_room(Date start_date, Date end_date, int capacity)
	{
		return fitting_rooms;
	}

	public static Room[] getAll_rooms() {
		return all_rooms;
	}
	public static Room getAll_room(int index) {
		return all_rooms[index];
	}
	
	public void Check_in_client(String reservation_id) {
		
	}
	
	public void Check_out_client(String reservation_id) {
		
	}

	public void setAll_rooms(Room[] all_rooms) {
		this.all_rooms = all_rooms;
	}

	public List<Room> getFitting_rooms(int cap) {
		for(int i=0;i<getAll_rooms().length;i++)
		{
			if(cap<=getAll_room(i).getCapacity())
			{
				fitting_rooms.add(getAll_room(i));
			}
		}
		return fitting_rooms;
	}

	public void setFitting_rooms(List<Room> fitting_rooms) {
		this.fitting_rooms = fitting_rooms;
	}

}
