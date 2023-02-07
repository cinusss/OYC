import {SafeAreaView} from 'react-native';
import React, {useLayoutEffect} from 'react';
import {useNavigation} from '@react-navigation/native';
import Header from '../components/Header';

const RecipeScreen = (): JSX.Element => {
  const navigation = useNavigation();

  useLayoutEffect(() => {
    navigation.setOptions({
      headerShown: false,
    });
  });

  return (
    <SafeAreaView>
      <Header title={'Dieta'} backArrow={true} />
    </SafeAreaView>
  );
};

export default RecipeScreen;
