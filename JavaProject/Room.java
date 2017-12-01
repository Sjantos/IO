
public class Room {
	private int room_number;
	private Room_status room_status;
	private int capacity;
	private String beds;
	
	public int getRoom_number() {
		return room_number;
	}
	
	public void setRoom_number(int room_number) {
		this.room_number = room_number;
	}
	
	public Room_status getRoom_status() {
		return room_status;
	}
	
	public void setRoom_status(Room_status room_status) {
		this.room_status = room_status;
	}
	
	public int getCapacity() {
		return capacity;
	}
	
	public void setCapacity(int capacity) {
		this.capacity = capacity;
	}
	
	public String getBeds() {
		return beds;
	}
	
	public void setBeds(String beds) {
		this.beds = beds;
	}

}
