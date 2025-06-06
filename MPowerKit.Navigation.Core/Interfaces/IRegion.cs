﻿namespace MPowerKit.Navigation.Interfaces;

public interface IRegion
{
    ValueTask<NavigationResult> ReplaceAll(string viewName, INavigationParameters? parameters);
    ValueTask<NavigationResult> Push(string viewName, INavigationParameters? parameters);
    ValueTask<NavigationResult> PushBackwards(string viewName, INavigationParameters? parameters);
    NavigationResult GoBack(INavigationParameters? parameters);
    NavigationResult GoForward(INavigationParameters? parameters);
    NavigationResult GoByName(string viewName, INavigationParameters? parameters);
    bool CanGoBack();
    bool CanGoForward();
    bool CanGoByName(string viewName);

    void NavigatedRecursively(INavigationParameters parameters, bool to);
    void DestroyAll();
    void DestroyRecursively(VisualElement view);
    void OnWindowLifecycleRecursively(bool resume);
    void OnPageLifecycleRecursively(bool appearing);
}