using Helpers.File;
using Helpers.Json;
using ShotTimer.DTOs.Application;
using ShotTimer.DTOs.Shooting;
using System.Collections.Generic;
using System.IO;

namespace ShotTimer.ApplicationCore.InizialatingData
{
    public class PopulateDataBL
    {
        private string _dataFilesFolder = string.Empty;

        private List<SpecialityDTO> _specialities = new List<SpecialityDTO>();

        public PopulateDataBL() 
        {
            _dataFilesFolder = new DirectoryInfo(@"C: \Users\Alejandro Blasco\Desktop\Para Julio\Peliculas").FullName;
        }

        public ResultDTO GenerateMandatoryData() 
        {
            ResultDTO response = new ResultDTO();

            _specialities = this.GetDefaulSpecialities();
            bool isCorrect = FileHelper.WriteFile(_dataFilesFolder, "Speciality.json", JsonHelper.Serialize(_dataFilesFolder));
            if (!isCorrect) response = new ResultDTO("Error al generar Speciality.json");

            return response;
        }

        private List<SpecialityDTO> GetDefaulSpecialities() 
        {
            List<SpecialityDTO> listToReturn = new List<SpecialityDTO>();

            listToReturn.Add(new SpecialityDTO("Plato"));
            listToReturn.Add(new SpecialityDTO("Precisión"));
            listToReturn.Add(new SpecialityDTO("Armas historicas"));
            listToReturn.Add(new SpecialityDTO("Recorridos de tiro"));
            listToReturn.Add(new SpecialityDTO("Alta precisión"));
            listToReturn.Add(new SpecialityDTO("F-class"));

            return listToReturn;
        }
        private List<ModalityDTO> GetDefaulModalities()
        {
            List<ModalityDTO> listToReturn = new List<ModalityDTO>();

            listToReturn.Add(new ModalityDTO("Olimpica"));
            listToReturn.Add(new ModalityDTO("Deportiva"));
            listToReturn.Add(new ModalityDTO("Personal"));

            return listToReturn;
        }

    }
}
