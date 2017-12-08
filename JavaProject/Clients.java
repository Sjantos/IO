import java.util.List;

public class Clients {
	
	private static List<Client> clients;
	

	public static void Register_client(String last_name, String first_name, String client_id, String email){
		Client klient = new Client(last_name, first_name, client_id, email);
		clients.add(klient);
		
	}


	public static List<Client> getClients() {
		return clients;
	}


	public void setClients(List<Client> clients) {
		this.clients = clients;
	}
}
