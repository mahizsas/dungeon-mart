﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DungeonMart.Data.Models;

namespace DungeonMart.Data.DAL
{
    public interface IDungeonMartContext
    {
        DbSet<CharacterClassEntity> CharacterClasses { get; set; }
        DbSet<ClassProgressionEntity> ClassProgressions { get; set; }
        DbSet<DomainEntity> Domains { get; set; }
        DbSet<EquipmentEntity> Equipments { get; set; }
        DbSet<FeatEntity> Feats { get; set; }
        DbSet<ItemEntity> Items { get; set; }
        DbSet<MonsterEntity> Monsters { get; set; }
        DbSet<PowerEntity> Powers { get; set; }
        DbSet<SkillEntity> Skills { get; set; }
        DbSet<SpellEntity> Spells { get; set; }

        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry(object entity);
    }
}
