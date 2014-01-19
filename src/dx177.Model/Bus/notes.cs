using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus
{
    [Serializable]
    public  class notes
    {

        string _OrderButtonDescr = "";
        public string OrderButtonDescr
        {
            get
            {
                return _OrderButtonDescr;
            }
            set
            {
                _OrderButtonDescr = value;
            }
        
        }

      
        string _OrderAlertDescr = "";
        public string OrderAlertDescr
        {
            get
            {
                return _OrderAlertDescr;
            }
            set
            {
                _OrderAlertDescr = value;
            }
        }


        string _NoteDescr = "";
        public string NoteDescr
        {
            get
            {
                return _NoteDescr;
            }
            set
            {
                _NoteDescr = value;
            }
        }

        int _orderButtonIsShow = 0;
        public int orderButtonIsShow
        {
            get
            {
                return _orderButtonIsShow;
            }
            set
            {
                _orderButtonIsShow = value;
            }
        }
   
   }
}
