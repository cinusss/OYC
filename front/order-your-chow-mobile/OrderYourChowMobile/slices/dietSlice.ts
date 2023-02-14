import {createSlice, PayloadAction} from '@reduxjs/toolkit';
import {RecipesListItem} from '../models/recipe/recipeList';
import {RootState} from '../store';

export interface DietState {
  dietDay: RecipesListItem[];
  activeRecipe?: RecipesListItem | null;
}

export interface RecipeCategory {
  categoryId: number;
  category: string;
}

const initialState: DietState = {
  dietDay: [],
  activeRecipe: null,
};

export const dietSlice = createSlice({
  name: 'diet',
  initialState,
  reducers: {
    setList: (state, action: PayloadAction<RecipesListItem[]>) => {
      state.dietDay = action.payload;
    },

    setActiveRecipe: (state, action: PayloadAction<number>) => {
      state.activeRecipe = state.dietDay.find(
        x => x.categoryId === action.payload,
      );
    },

    setIsFavourite: (state, action: PayloadAction<number>) => {
      const recipe = state.dietDay.find(x => x.recipeId === action.payload);
      if (recipe) {
        recipe.favourite = !recipe.favourite;
      }
    },
  },
});

export const {setList, setIsFavourite, setActiveRecipe} = dietSlice.actions;

export const selectDietDay = (state: RootState) => state.diet.dietDay;
export const selectRecipeCategoriesForDietDay = (state: RootState) =>
  state.diet.dietDay.map(
    item =>
      ({
        category: item.categoryName,
        categoryId: item.categoryId,
      } as RecipeCategory),
  );
export const selectActiveCategoryId = (state: RootState) =>
  state.diet.activeRecipe?.categoryId;

export default dietSlice.reducer;
