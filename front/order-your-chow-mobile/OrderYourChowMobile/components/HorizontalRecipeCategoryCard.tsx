import {Text, TouchableOpacity, View} from 'react-native';
import React from 'react';
import {RecipeCategory, setActiveRecipe} from '../slices/dietSlice';
import {useDispatch} from 'react-redux';

interface HorizontalRecipeCategoryCardProps {
  recipeCategory: RecipeCategory;
  isActiveCategory: boolean;
}

const HorizontalRecipeCategoryCard: React.FC<
  HorizontalRecipeCategoryCardProps
> = ({recipeCategory, isActiveCategory}) => {
  const dispatch = useDispatch();
  const setActiveRecipeState = (categoryId: number) => {
    dispatch(setActiveRecipe(categoryId));
  };
  return (
    <TouchableOpacity
      onPress={() => {
        setActiveRecipeState(recipeCategory?.categoryId);
      }}
      className={
        !isActiveCategory
          ? 'pb-3 items-center mx-6 space-x-2 mb-2'
          : 'rounded-md items-center mx-6 space-x-2 bg-teal-500 pb-3 mb-2 scale-125'
      }>
      {' '}
      <View>
        <Text className="font-bold text-base">{recipeCategory?.category}</Text>
      </View>
    </TouchableOpacity>
  );
};

export default HorizontalRecipeCategoryCard;
