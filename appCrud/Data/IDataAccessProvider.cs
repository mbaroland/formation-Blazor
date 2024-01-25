using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appCrud.Data
{
    public interface IDataAccessProvider
    {
        void AddPatientRecord(Patient patient);
        void UpdatePatientRecord(Patient patient);
        void DeletePatientRecord(Patient patient);
        Patient GetPatientRecord(int Id );
        List<Patient> GetAllPatientRecord();
    }
}