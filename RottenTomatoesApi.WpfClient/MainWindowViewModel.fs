namespace RottenTomatoesApi.ViewModel

open System
open System.Collections.ObjectModel
open System.Windows
open System.Windows.Data
open System.Windows.Input
open System.ComponentModel
open RottenTomatoesApi
open RottenTomatoesApi.Models

type MainWindowViewModel() =
    inherit ViewModelBase()

      member x.Movies with get () = Api.Movies.GetBoxOffice().Movies |> Seq.map(fun m -> { Name = m.Title; Year = m.Year; Poster = m.Posters.Original })