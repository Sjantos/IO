
public class Reservation {
	private String reservation_id;
	private Date start_date;
	private Client client;
	private Date emd_date;
	private int room_number;
	private boolean busy;
	
	public String getReservation_id() {
		return reservation_id;
	}
	
	public void setReservation_id(String reservation_id) {
		this.reservation_id = reservation_id;
	}
	
	public Date getStart_date() {
		return start_date;
	}
	
	public void setStart_date(Date start_date) {
		this.start_date = start_date;
	}
	
	public Client getClient() {
		return client;
	}
	
	public void setClient(Client client) {
		this.client = client;
	}
	
	public Date getEmd_date() {
		return emd_date;
	}
	
	public void setEmd_date(Date emd_date) {
		this.emd_date = emd_date;
	}
	
	public int getRoom_number() {
		return room_number;
	}
	
	public void setRoom_number(int room_number) {
		this.room_number = room_number;
	}

	public boolean isBusy() {
		return busy;
	}

	public void setBusy(boolean busy) {
		this.busy = busy;
	}

}
