import {ScrollView} from 'react-native';
import React from 'react';
import {useSelector} from 'react-redux';
import {
  selectActiveCategoryId,
  selectRecipeCategoriesForDietDay,
} from '../slices/dietSlice';
import HorizontalRecipeCategoryCard from './HorizontalRecipeCategoryCard';

const HorizontalRecipeCategoryPicker = () => {
  const recipeCategories = useSelector(selectRecipeCategoriesForDietDay);
  const activeCategory = useSelector(selectActiveCategoryId);
  return (
    <ScrollView
      className="pb-2 bg-fuchsia-50"
      // eslint-disable-next-line react-native/no-inline-styles
      contentContainerStyle={{paddingHorizontal: 15, paddingTop: 10}}
      horizontal
      showsHorizontalScrollIndicator={false}>
      {recipeCategories?.map(category => (
        <HorizontalRecipeCategoryCard
          recipeCategory={category}
          isActiveCategory={activeCategory === category.categoryId}
        />
      ))}
    </ScrollView>
  );
};

export default HorizontalRecipeCategoryPicker;
