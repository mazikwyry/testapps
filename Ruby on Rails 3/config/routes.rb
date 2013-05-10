Testapp::Application.routes.draw do
  resources :comments


  resources :news


  root :to => 'application#index'
end
