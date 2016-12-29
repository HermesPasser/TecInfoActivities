/*
	Douglas Silva Lacerda
*/

package banco;
import java.sql.*;
import javax.swing.JOptionPane;
public class Conexao {

	String driver	="com.mySql.jdbc.Driver";
	String login	="root";
	String senha	="123456";
	String url		="jdbc:mysql://localhost/almoxarifado";
	
	//Connection conexao = null;
	public ResultSet rs = null;
	
	/*public void conectar(){
		try { 
			Class.forName(driver);
			conexao = DriverManager.getConnection(url,login,senha);
			System.out.println("Conectado com sucesso");
		} catch (ClassNotFoundException | SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar conectar.\nErro: "+e);
		} 
	}*/
	/*public void desconectar(){
		try {
			conexao.close();
		} catch (SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar desconectar.\nErro: "+e);
		}
	}*/
	public String crudDado(String cod) {
		Connection conexao = null;
		try { 
			Class.forName(driver);
		    conexao = DriverManager.getConnection(url,login,senha);
			System.out.println("Conectado com sucesso");
		} catch (ClassNotFoundException | SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar conectar.\nErro: "+e);
			return null;
		} 
		PreparedStatement state = null; 
		
		try{
			state = (PreparedStatement) conexao.createStatement();
			state.executeUpdate(cod);
			state.close();
			JOptionPane.showMessageDialog(null,"Sucesso ao realizar a ação.");
		}catch (SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar enviar os dados.\nErro: "+e);
		}
		try {
			conexao.close();
		} catch (SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar desconectar.\nErro: "+e);
			return null;
		}
		return cod; //inutil já que ele envia para o banco no try
	}
	public String mostrarDado(String cod){
		Connection conexao = null;
		try { 
			Class.forName(driver);
		    conexao = DriverManager.getConnection(url,login,senha);
			System.out.println("Conectado com sucesso");
		} catch (ClassNotFoundException | SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar conectar.\nErro: "+e);
			return null;
		} 
		PreparedStatement state = null;
		try{
			state = (PreparedStatement) conexao.createStatement();
			String query = "SELECT * FROM "+cod+";"; //cod pode ser produto ou fornecedor
			try {
				rs = state.executeQuery(query);
			}catch (SQLException e) {JOptionPane.showMessageDialog(null,"Erro ao realizar ação.\nErro: "+e);}
			state.close();
			JOptionPane.showMessageDialog(null,"Sucesso ao realizar a ação.");
		}catch (SQLException e) {JOptionPane.showMessageDialog(null,"Erro ao realizar ação..\nErro: "+e);}
		try {
			conexao.close();
		} catch (SQLException e) {
			e.printStackTrace();
			JOptionPane.showMessageDialog(null,"Erro ao tentar desconectar.\nErro: "+e);
			return null;
		}
		return cod; 
	}
	
	//getters e setters para futuro sistema de login
	
    public String getDriver() {return driver;}

    public void setDriver(String d) {driver = d;}

    public String getUrl() {return url;}

    public void setUrl(String u) {url = u;}

    public String getLogin() {return login;}

    public void setLogin(String l) {login = l;}

    public String getSenhaBanco() {return senha;}

    public void setSenhaBanco (String s) {senha = s;}
}