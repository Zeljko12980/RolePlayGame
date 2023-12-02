using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Fight;
using dotnet_rpg.DTOs.Fight;

namespace dotnet_rpg.Service.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighScoreDto>>> GetHighscore();
    }
}