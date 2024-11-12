﻿namespace ExtraAdvancedMultiTier.Business.Abstractions;


public interface IFacade : IServiceContainer {

    public IFacadeContainer? GetParent();

    public T? GetParent<T>() where T : class, IFacadeContainer;

    public T? GetMainView<T>() where T : class, IView;

}
