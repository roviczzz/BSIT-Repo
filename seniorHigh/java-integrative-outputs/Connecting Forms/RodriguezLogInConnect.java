/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rodriguezproject;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author rovic
 */
public class RodriguezLogInConnect
{
    public static Connection connectdb()
    {
        Connection con=null;
        try
        {
            con=DriverManager.getConnection("jdbc:mysql://localhost:3306/mysql?zeroDateTimeBehavior=convertToNull","root","root");
        } catch (SQLException ex)
        {
            Logger.getLogger(RodriguezLogInConnect.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
        
        
    
    }
    
}
