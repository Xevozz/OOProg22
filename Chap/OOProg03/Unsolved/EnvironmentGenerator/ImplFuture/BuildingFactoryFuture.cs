﻿
public class BuildingFactoryFuture : IBuildingFactory
{
    public IBuilding Create()
    {
        return new Skyscraper();
    }
}
