using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MVVMVoorbeeld.ViewModel
{
    public class TekstMetOpmaakVM: ViewModelBase
    {
        private Model.TekstMetOpmaak opgemaakteTekst;

        public TekstMetOpmaakVM(Model.TekstMetOpmaak deTekst)
        {
            opgemaakteTekst = deTekst;
        }

        public string Inhoud
        {
            get
            {
                return opgemaakteTekst.Inhoud;
            }
            set
            {
                opgemaakteTekst.Inhoud = value;
                RaisePropertyChanged("Inhoud");
            }
        }

        public Boolean Vet
        {
            get
            {
                return opgemaakteTekst.Vet;
            }
            set
            {
                opgemaakteTekst.Vet = value;
                RaisePropertyChanged("Vet");
            }
        }

        public Boolean Schuin
        {
            get
            {
                return opgemaakteTekst.Schuin;
            }
            set
            {
                opgemaakteTekst.Schuin = value;
                RaisePropertyChanged("Schuin");
            }
        }
    }
}
