import {View, Text, TouchableOpacity} from 'react-native';
import React from 'react';
import {ArrowLeftIcon} from 'react-native-heroicons/solid';
import {useNavigation} from '@react-navigation/native';

interface HeaderProps {
  title: string;
  backArrow?: boolean;
}

const Header: React.FC<HeaderProps> = ({title, backArrow}) => {
  const navigation = useNavigation();
  return (
    <View className="relative">
      <Text className="font-bold text-xl bg-white py-3 border-gray-400 border-b-2 border-dotted border-spacing-2 text-center">
        {title}
      </Text>
      {backArrow && (
        <TouchableOpacity
          onPress={navigation.goBack}
          className="absolute top-2 left-5 p-2 bg-teal-500 rounded-full">
          <ArrowLeftIcon size={22} color="#ffffff" />
        </TouchableOpacity>
      )}
    </View>
  );
};

export default Header;
