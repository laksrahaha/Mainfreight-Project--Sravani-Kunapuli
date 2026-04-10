using System;

namespace MainfreightProject;


    public class Shipment
    {

        private string shipmentID;
        private string status;
        private string currentLocation;
        private string deliveryStatus;

       //this si the contructor class i ma intialising the objects , whihc are the shipment detials needed
        public Shipment(string shipmentID,string status , string currentLocation, string deliveryStatus)
        {
            this.shipmentID = shipmentID;
            this.status = status;
            this.currentLocation = currentLocation;
            this.deliveryStatus = deliveryStatus;
        }

        public void TrackShipment()
        {
            //this is the message that will dislpay where the shipment currently is
            Console.WriteLine("Shipment" + shipmentID + " is located currently at" + currentLocation);
        
        }


        // this method is void because it needs to change the vlaue stord in the object , there is no need for it to send the value back
        public void UpdateStatus(string newStatus)
        {
            status = newStatus;// not using this. becasue parameter names are not same
        
        }

        public string getShipmentInfo()
        {
            // di[lays the inofmration tha tis requested on one line]
            return "Shipment ID:" + shipmentID +
            "\nShipment Status:" + status +
            "\nCurrent Location: " + currentLocation +
            "\nDelivery Status: " + deliveryStatus;
        }
    
    }


