using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.DTOs.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAll();
       Task< ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddNewCharacter(AddCharacterDto newCharacter);
          Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
           Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}